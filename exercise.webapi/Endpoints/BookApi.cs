using exercise.webapi.Models.DTO;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            app.MapGet("/books", GetBooks);
            app.MapGet("/books/{id}", GetBookById);
            app.MapPut("/books/changeAuthor", ChangeAuthorById);
            app.MapDelete("/books/{id}", DeleteBookById);
            app.MapPost("/books", CreateBook);
        }

        private static async Task<IResult> GetBookById(int id, IBookRepository bookRepository)
        {
            var books = await bookRepository.GetBookById(id);
            if (books == null) { return TypedResults.NotFound("Book not found"); }
            return TypedResults.Ok(books);
        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            return TypedResults.Ok(books);
        }

        private static async Task<IResult> ChangeAuthorById([FromBody] UpdateBookAuthorDTO updateDTO, IBookRepository bookRepository)
        {
            var books = await bookRepository.ChangeAuthorById(updateDTO);
            if (books == null)
            {
                return TypedResults.BadRequest();
            }
            return TypedResults.Ok(books);
        }

        private static async Task<IResult> DeleteBookById(int id, IBookRepository bookRepository)
        {
            var books = await bookRepository.DeleteBookById(id);
            if (books == -1) { return TypedResults.BadRequest("Book Id not found"); }
            return TypedResults.Ok();
        }

        private static async Task<IResult> CreateBook(CreateBookDTO createDTO, IBookRepository bookRepository)
        {
            var books = await bookRepository.CreateBook(createDTO);
            if (books == -1) { return TypedResults.BadRequest("Book object invalid"); }
            if (books == -2) { return TypedResults.NotFound("Author Id invalid"); }
            return TypedResults.Ok();
        }
    }
}
