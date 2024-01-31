using exercise.webapi.Models;
using exercise.webapi.Repository;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            var books = app.MapGroup("books");
            books.MapGet("/", GetBooks);
            books.MapGet("/{id}", GetBookById);
            books.MapPost("/", CreateBook);
            books.MapPut("/{id}", UpdateBook);
            books.MapDelete("/{id}", DeleteBook);
        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            return TypedResults.Ok(books);
        }

        private static async Task<IResult> GetBookById(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetBookById(id);
            return TypedResults.Ok(book);
        }

        private static async Task<IResult> UpdateBook(IBookRepository bookRepository, int bookId, int newAuthorId)
        {
            var book = await bookRepository.UpdateBook(bookId, newAuthorId);
            return TypedResults.Ok(book);
        }

        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int bookId)
        {
            var book = await bookRepository.DeleteBook(bookId);
            return TypedResults.Ok(book);
        }

        private static Task CreateBook(HttpContext context)
        {
            throw new NotImplementedException();
        }
    }
}
