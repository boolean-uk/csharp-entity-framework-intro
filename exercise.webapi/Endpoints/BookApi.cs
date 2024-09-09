using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using exercise.webapi.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            var books = app.MapGroup("book");
            books.MapGet("/", GetBooks);
            books.MapGet("/{id}", GetBookById);
            books.MapPut("/{id}", UpdateBook);
            books.MapDelete("/{id}", DeleteById);
            books.MapPost("/", CreateBook);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            GetBooksResponse response = new GetBooksResponse();

            var results = await bookRepository.GetAllBooks();

            foreach (var b in results) 
            {
                DTOBook book = new DTOBook();
                book.Title = b.Title;
                book.ID = b.Id;

                if (b.AuthorId != null)
                {
                    DTOAuthor author = new DTOAuthor();
                    author.Name = b.Author.FirstName + " " + b.Author.LastName;
                    author.Email = b.Author.Email;

                    book.Author = author;
                }
                
                response.Books.Add(book);
            }
            return TypedResults.Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetBookById(IBookRepository bookRepository ,int id)
        {
            Book result = await bookRepository.GetBookById(id);
            if (result == null)
            {
                return TypedResults.NotFound("No such book");
            }
            else
            {
                DTOBook book = new DTOBook();
                book.Title = result.Title;
                book.ID = result.Id;

                if (result.AuthorId != null) 
                {
                    DTOAuthor author = new DTOAuthor();
                    author.Name = result.Author.FirstName + " " + result.Author.LastName;
                    author.Email = result.Author.Email;

                    book.Author = author;
                }

                return TypedResults.Ok(book);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> UpdateBook(IAuthorRepository authorRepository, IBookRepository bookRepository, int id, BookPutModel model)
        {
            var editing = await bookRepository.GetBookById(id);
            if (editing == null)
            {
                return TypedResults.NotFound("No such book");
            }
            DTOBook editedBook = new DTOBook();
            editedBook.Title = editing.Title;
            editedBook.ID = editing.Id;

            DTOAuthor dtoAuthor = new DTOAuthor();

            var exists = await authorRepository.GetAuthorByName(model.FirstName, model.LastName);

            if (exists != null) 
            {
                editing.AuthorId = exists.Id;

                dtoAuthor.Name = exists.FirstName + " " + exists.LastName;
                dtoAuthor.Email = exists.Email;
                editedBook.Author = dtoAuthor;
                await bookRepository.UpdateById(id, editing);
                return TypedResults.Ok(editedBook);
            }
            else
            {
                Author author = new Author();
                author.FirstName = model.FirstName;
                author.LastName = model.LastName;
                author.Email = model.Email;

                editing.Author = author;
                await bookRepository.UpdateById(id, editing);

                dtoAuthor.Name = editing.Author.FirstName + " " + editing.Author.LastName;
                dtoAuthor.Email = editing.Author.Email;

                editedBook.Author = dtoAuthor;
                return TypedResults.Ok(editedBook);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> DeleteById(IBookRepository bookRepository, int id)
        {
            var deleted = await bookRepository.DeleteById(id);

            if (deleted == null) 
            {
                return TypedResults.NotFound("No such book");
            }
            else
            {
                DTOBook deletedBook = new DTOBook();
                deletedBook.Title = deleted.Title;
                deletedBook.ID = deleted.Id;

                DTOAuthor author = new DTOAuthor();
                author.Name = deleted.Author.FirstName + " " + deleted.Author.LastName;
                author.Email = deleted.Author.Email;

                deletedBook.Author = author;

                return TypedResults.Ok(deletedBook);
            }
            
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> CreateBook(IAuthorRepository authorRepository, IBookRepository bookRepository, BookPostModel model)
        {
            try
            {
                var author = await authorRepository.GetAuthorById(model.AuthorId);
                if (author != null)
                {
                    model.AuthorId = author.Id;
                    var newBook = await bookRepository.CreateBook(new Book() { Title = model.Title, AuthorId = model.AuthorId });
                    return TypedResults.Ok(newBook);
                }
                else
                {
                    return TypedResults.NotFound("Author not found");
                }
            }
            catch (Exception ex) 
            {
                return TypedResults.Ok(ex.Message+" No such author exists");
            }
        }
    }
}
