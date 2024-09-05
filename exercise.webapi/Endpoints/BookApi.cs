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
            books.MapGet("/{id}", GetBook);
            books.MapPut("/", UpdateBook);
            books.MapPost("/", CreateBook);
            books.MapDelete("/", DeleteBook);
        }

        private static async Task<IResult> DeleteBook(IBookRepository repository, int id)
        {
            Book book = repository.DeleteBook(id);
            return TypedResults.Ok(book);
        }

        private static async Task<IResult> CreateBook(IBookRepository repository, string Title, int AuthorId)
        {
            Book book = await repository.CreateBook(Title, AuthorId);
            return TypedResults.Ok(book);
        }

        private static async Task<IResult> UpdateBook(IBookRepository repository, int id, string Title, int AuthorId)
        {
            Book book = await repository.UpdateBook(id, Title, AuthorId);
            return TypedResults.Ok(book);
        }

        private static async Task<IResult> GetBook(IBookRepository repository, int id)
        {
            BookDTO book = await repository.GetBook(id);
            return TypedResults.Ok(book);
        }

        private static async Task<IResult> GetBooks(IBookRepository repository)
        {
            var books = await repository.GetAllBooks();
            return TypedResults.Ok(books);
        }
    }
}
