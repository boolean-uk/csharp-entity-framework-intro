using exercise.webapi.Models;
using exercise.webapi.Repository;
using exercise.webapi.Services;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {

        public static void ConfigureBooksApi(this WebApplication app)
        {
            app.MapGet("/books", GetBooks);
            app.MapGet("/books{id}", GetBook);
        }

        private static async Task<IResult> GetBooks(BookService bookService)
        {
            var books = await bookService.GetBooks();
            return TypedResults.Ok(books);
        }

        private static async Task<IResult> GetBook(BookService bookService, int id)
        {
            var book = await bookService.GetBook(id);

            return book != null ? TypedResults.Ok(book) : TypedResults.NotFound("Book not found");
        }

        
    }
}
