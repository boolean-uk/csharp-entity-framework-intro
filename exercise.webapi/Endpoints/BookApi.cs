using exercise.webapi.Models;
using exercise.webapi.Repository;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            app.MapGet("/books", GetBooks);
            app.MapGet("/books/{id}", GetBook);
            app.MapPut("/books/{id}", UpdateBook);
            app.MapDelete("/books/{id}", DeleteBook);
            app.MapPost("/books/", CreateBook);
        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            return TypedResults.Ok(books);
        }
        private static async Task<IResult> GetBook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetBookById(id);
            return TypedResults.Ok(book);
        }
        private static async Task<IResult> UpdateBook(IBookRepository bookRepository, int id, int NewAuthorId)
        {
            var book = await bookRepository.UpdateBook(id,NewAuthorId);
            return TypedResults.Ok(book);
        }
        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.DeleteBook(id);
            return TypedResults.Ok(book);
        }
        private static async Task<IResult> CreateBook(IBookRepository bookRepository, Book book)
        {
            var result = await bookRepository.CreateBook(book);
            if (result == null) { return TypedResults.NotFound("ID not found"); }

            return TypedResults.Ok(result);
        }
    }
}
