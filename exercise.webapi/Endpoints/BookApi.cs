using System.Reflection;
using exercise.webapi.Data;
using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            var books = app.MapGroup("books");

            books.MapGet("/", GetBooks);
            books.MapGet("/{id}", GetBook);
            books.MapPut("/{id}", UpdateBook);
            books.MapDelete("/{id}", DeleteBook);
            books.MapPost("/", AddBook);
            books.MapPut("/removeAuthor/{id}", RemoveAuthor);
            books.MapPut("/addAuthor/{id}", AddAuthor);
        }
        private static async Task<IResult> AddAuthor(IBookRepository bookRepository, IAuthorRepository authorRepository, int id, int authId)
        {
            BookDTO bookDTO = new BookDTO();
            Book target = await bookRepository.GetBook(id);
            

            var result = await bookRepository.AssignAuthor(id, authId);

            Author author = await authorRepository.GetAuthor(target.AuthorId);
            author.Books.Add(target);

            bookDTO.Id = result.Id;
            bookDTO.Title = result.Title;
            bookDTO.AuthorId = result.AuthorId;
            bookDTO.AuthorName = result.Author.FirstName + " " + result.Author.LastName;


            return TypedResults.Ok(bookDTO);
        }
        private static async Task<IResult> RemoveAuthor(IBookRepository bookRepository, IAuthorRepository authorRepository, int id)
        {
            BookDTO bookDTO = new BookDTO();
            Book target = await bookRepository.GetBook(id);
            Author author = await authorRepository.GetAuthor(target.AuthorId);
            author.Books.Remove(target);

            var result = await bookRepository.RemoveAuthor(id);
            bookDTO.Id = result.Id;
            bookDTO.Title = result.Title;
            bookDTO.AuthorId = result.AuthorId;
            bookDTO.AuthorName = "";


            return TypedResults.Ok(bookDTO);
        }
        private static async Task<IResult> AddBook(IBookRepository bookRepository, BookPost model)
        {
            BookDTO bookDTO = new BookDTO();

            Book book = new Book()
            {
                Title = model.Title,
                AuthorId = model.AuthorId
            };
            
           if( await bookRepository.AddBook(book) == null)
            {
                return TypedResults.NotFound("Author not found");
            }

            bookDTO.Id = book.Id;
            bookDTO.Title = book.Title;
            bookDTO.AuthorId = book.AuthorId;
            bookDTO.AuthorName = book.Author.FirstName + " " + book.Author.LastName;


            return TypedResults.Created($"https://localhost:7188/products/{bookDTO.Id}", bookDTO);
        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            List<BookDTO> booksDTO = new List<BookDTO>();
            var books = await bookRepository.GetAllBooks();
            foreach (var book in books)
            {
                booksDTO.Add(new BookDTO
                {
                    Id = book.Id,
                    Title = book.Title,
                    AuthorId = book.AuthorId,
                    AuthorName = book.Author.FirstName + " " + book.Author.LastName,
                });
            }
            return TypedResults.Ok(booksDTO);
        }

        private static async Task<IResult> GetBook(IBookRepository bookRepository, int id)
        {
            BookDTO bookDTO = new BookDTO();
            var book = bookRepository.GetBook(id);
            bookDTO.Id = book.Result.Id;
            bookDTO.Title = book.Result.Title;
            bookDTO.AuthorId = book.Result.AuthorId;
            if(bookDTO.AuthorId != 0)
                bookDTO.AuthorName = book.Result.Author.FirstName + " " + book.Result.Author.LastName;
            return TypedResults.Ok(bookDTO);
        }
        private static async Task<IResult> UpdateBook(IBookRepository bookRepository, int id, BookPut model)
        {

            try
            {
                BookDTO bookDTO = new BookDTO();
                var target = await bookRepository.GetBook(id);
                if (target == null) return TypedResults.NotFound("Product was not found");

                if (model.AuthorId != null) target.AuthorId = model.AuthorId.Value;

                var result = await bookRepository.UpdateBook(target);
                bookDTO.Id = result.Id;
                bookDTO.Title = result.Title;
                bookDTO.AuthorId = result.AuthorId;
                bookDTO.AuthorName = result.Author.FirstName + " " + result.Author.LastName;
                return Results.Created($"https://localhost:7188/books/{id}", bookDTO);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteBook(IBookRepository repository, int id)
        {
            try
            {
                var model = await repository.GetBook(id);
                if (model == null)
                    return TypedResults.NotFound("Book was not found");
                if (await repository.DeleteBook(id)) return Results.Ok(new { When = DateTime.Now, Status = "Deleted", Name = model.Title, AuthorId = model.AuthorId, Author = model.Author.FirstName + " " + model.Author.LastName });
                return TypedResults.NotFound();
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
