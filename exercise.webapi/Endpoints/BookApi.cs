using exercise.webapi.Models;
using exercise.webapi.Repository;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            var bookGroup = app.MapGroup("/books");
            bookGroup.MapGet("/", GetBooks);
            bookGroup.MapGet("/{id}", GetBook);
            bookGroup.MapPut("/{id}", UpdateBook);
            bookGroup.MapDelete("/{id}", DeleteBook);
            bookGroup.MapPost("/", CreateBook);
        }

        private static async Task<IResult> GetBooks(IRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            return TypedResults.Ok(books);
        }
        private static async Task<IResult> GetBook(IRepository bookRepository, int id)
        {
            var book = await bookRepository.GetBookById(id);
            return TypedResults.Ok(book);
        }
        private static async Task<IResult> UpdateBook(IRepository bookRepository, int id, int NewAuthorId)
        {
            var book = await bookRepository.UpdateBook(id,NewAuthorId);
            return TypedResults.Ok(book);
        }
        private static async Task<IResult> DeleteBook(IRepository bookRepository, int id)
        {
            var book = await bookRepository.DeleteBook(id);
            return TypedResults.Ok(book);
        }
        private static async Task<IResult> CreateBook(IRepository bookRepository, Book book)
        {
            var result = await bookRepository.CreateBook(book);
            if (result == null) { return TypedResults.NotFound("ID not found"); }

            return TypedResults.Ok(result);
        }
    }
}
