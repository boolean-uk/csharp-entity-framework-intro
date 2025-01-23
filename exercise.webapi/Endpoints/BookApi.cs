using exercise.webapi.Dto;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            app.MapGet("/books", GetBooks);
            app.MapGet("/books/{id}", GetBook);
        }

        [ProducesResponseType(typeof(IEnumerable<BookResponse>), StatusCodes.Status200OK)]
        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            var response = books.Select(b => new BookResponse(b));
            
            return TypedResults.Ok(response);
        }
        
        [ProducesResponseType(typeof(BookResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
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
