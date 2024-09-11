using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            app.MapGet("/books", GetBooks);
            app.MapGet("/books/{id}", GetABook);
            app.MapPut("/books/{id}", UpdateBookAuthor);
            app.MapPost("/books/{id}", CreateBook);
        }

        private static async Task<IResult> CreateBook(IAuthorRepository authorRepo, IBookRepository bookRepo, BookPostModel model)
        {
            try
            {

                var result = await bookRepo.AddBook(new Book()
                {
                    Title = model.Title,
                    AuthorId = (int)model.AuthorId
                    
                });
                
                if (result.AuthorId == null)
                {
                    return TypedResults.NotFound("Author not found");
                }

                var newAuthor = authorRepo.GetAuthorById(result.AuthorId).Result;

                result.Author = new Author(){FirstName = newAuthor.FirstName, LastName = newAuthor.LastName, Email = newAuthor.Email, Books = newAuthor.Books };
                return TypedResults.Ok(result);

            }
            catch (Exception ex)
            {
                return TypedResults.BadRequest(ex.Message);
            }
        }

        private static async Task<IResult> UpdateBookAuthor(IAuthorRepository authorRepo, IBookRepository bookRepository, int id, BookPutModel model)
        {
            try
            {
                var target = await bookRepository.GetBookById(id);

                target.AuthorId = model.AuthorId == 0 ? target.AuthorId : model.AuthorId;
                             
                //update author for current book by authorId
                Author newAuthor = authorRepo.GetAuthorById(target.AuthorId).Result;
                target.Author = newAuthor;

                await bookRepository.UpdateBookAuthorById(target, id);
                return TypedResults.Ok(new
                {
                    Id = target.Id,
                    Title = target.Title,
                    AuthorId = target.AuthorId,
                    Author = target.Author
                });
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetABook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetBookById(id);
            //return custom object
            return TypedResults.Ok(new {Id = book.Id, title = book.Title, Author = book.Author, AuthorId = book.AuthorId});
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBooks(IBookRepository bookRepository, IAuthorRepository authRepo)
        {
            var books = await bookRepository.GetAllBooks();

            List<Object> bookList = new List<Object>();
            

            foreach (var book in books) 
            {

                bookList.Add(new
                {
                    id = book.Id,
                    title = book.Title,
                    AuthorId = book.AuthorId,
                    author = book.Author.FirstName,
                    publisher = book.Publisher.Name
                });
            }

            //return new anon element
            return TypedResults.Ok(bookList);
        }
    }
}
