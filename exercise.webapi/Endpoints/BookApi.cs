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
            app.MapGet("/books/{id}", GetBook);
            app.MapPut("/books/{id}", UpdateBook);
            app.MapDelete("/books/{id}", DeleteBook);
            app.MapPost("/books", AddBook);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBooks(IRepository<Book, BookDTO> bookRepository)
        {
            var books = await bookRepository.GetAll();

            List<BookResponse> response = new List<BookResponse>();

            foreach (var book in books)
            {
                response.Add(ResponseGenerator.GenerateBookResponse(book));
            }

            return TypedResults.Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetBook(IRepository<Book, BookDTO> bookRepository, int id)
        {
            Book book = await bookRepository.Get(id);
            return book != null ? TypedResults.Ok(ResponseGenerator.GenerateBookResponse(book)) : TypedResults.NotFound("Not found");
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> UpdateBook(IRepository<Book, BookDTO> bookRepository, BookDTO dto, int id)
        {
           
            Book book = await bookRepository.Update(id, dto);

            return book != null ? TypedResults.Created("/", ResponseGenerator.GenerateBookResponse(book)) : TypedResults.NotFound("Not found");
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> DeleteBook(IRepository<Book, BookDTO> bookRepository, int id)
        {
            Book b = await bookRepository.Delete(id);
            return b != null ? TypedResults.Ok(ResponseGenerator.GenerateBookResponse(b)) : TypedResults.NotFound();
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        private static async Task<IResult> AddBook(IRepository<Book, BookDTO> bookRepository, BookDTO bDTO)
        {
            Book b = await bookRepository.Add(bDTO);
            return b != null ? TypedResults.Ok(ResponseGenerator.GenerateBookResponse(b)) : TypedResults.NotFound("Author not found");
        }
    }
}
