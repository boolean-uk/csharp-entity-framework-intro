using exercise.webapi.DTOs;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            app.MapGet("/books", GetBooks);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            List<BookDTO> results = new List<BookDTO>();
            var books = await bookRepository.GetAllBooks();

            foreach(var book in books)
            {
                BookDTO bookDTO = new BookDTO();
                bookDTO.Title = book.Title,
                Authors = book.

                results.Add(bookDTO);
            }
            return TypedResults.Ok(results);
        }
    }
}
