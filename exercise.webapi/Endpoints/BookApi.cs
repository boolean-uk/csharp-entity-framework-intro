using exercise.webapi.DTO;
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
            books.MapGet("{id}", GetBook);
            books.MapPut("{id}", UpdateBook);
            books.MapDelete("{id}", DeleteBook);
            books.MapPost("/CreateBook", CreateBook);
        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            return TypedResults.Ok(books);
        }

        public static async Task<IResult> GetBook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetBook(id);
            return TypedResults.Ok(book);
        }

        public static async Task<IResult> UpdateBook(IBookRepository bookRepository, BookDTO newBook, int id)
        {
            var book = await bookRepository.UpdateBook(newBook, id);

            return TypedResults.Ok(book);
        }

        public static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.DeleteBook(id);

            return TypedResults.Ok(book);
        }

        public static async Task<IResult> CreateBook(IBookRepository bookRepository, BookDTO book)
        {
            var bookDTO = await bookRepository.CreateBook(book);

            return TypedResults.Ok(bookDTO);
        }
    }
}
