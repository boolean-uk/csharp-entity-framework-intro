using exercise.webapi.Models;
using exercise.webapi.Repository;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            var bookGroup = app.MapGroup("books");
            bookGroup.MapGet("", GetBooks);
            bookGroup.MapGet("{id}", GetBook);
            bookGroup.MapPut("{id}", PutAuthor);
            bookGroup.MapDelete("{id}", DeleteBook);
            bookGroup.MapPost("", CreateBook);
        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            return TypedResults.Ok(await bookRepository.GetAllBooks());
        }

        private static async Task<IResult> GetBook(IBookRepository bookRepository, int id)
        {
            return TypedResults.Ok(await bookRepository.GetBook(id));
        }

        private static async Task<IResult> PutAuthor(IBookRepository bookRepository, int id, int[] authorId)
        {
            return TypedResults.Ok(await bookRepository.PutAuthor(id, authorId));
        }

        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            bookRepository.DeleteBook(id);
            return TypedResults.Ok();
        }

        private static async Task<IResult> CreateBook(IBookRepository bookRepository, Book book)
        {
            return TypedResults.Ok(bookRepository.CreateBook(book));
        }
    }
}
