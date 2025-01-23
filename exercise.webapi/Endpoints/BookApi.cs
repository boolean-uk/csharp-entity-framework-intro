using exercise.webapi.Dto;
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
        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            var response = books.Select(b => new BookResponse(b));
            
            return TypedResults.Ok(response);
        }
        
        private static async Task<IResult> GetBook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetBookById(id);
            if (book == null)
            {
                return TypedResults.NotFound();
            }
            return TypedResults.Ok(new BookResponse(book));
        }
    }
}
