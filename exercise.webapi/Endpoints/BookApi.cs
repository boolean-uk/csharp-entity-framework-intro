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
            app.MapGet("/books", GetBooks);
            app.MapGet("/books/{id}", GetBook);
            app.MapPost("/books", AddBook);
            app.MapPut("/books/{id}", UpdateBook);
            app.MapDelete("/books/{id}", DeleteBook);
        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            return TypedResults.Ok(BookResponseDTO.FromRepository(books));
        }

        private static async Task<IResult> GetBook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetBook(id);
            return TypedResults.Ok(new BookResponseDTO(book));
        }

        private static async Task<IResult> AddBook (IBookRepository bookRepository, CreateBookPayload payload)
        {
            var book = await bookRepository.AddBook(payload);
            return TypedResults.Created($"/{book.Id}", new BookResponseDTO(book));
        }

        private static async Task<IResult> UpdateBook(IBookRepository bookRepository, int id, UpdateBookPayload payload)
        {
            var book = await bookRepository.UpdateBook(id, payload);
            if (book == null)
            {
                return TypedResults.NotFound();
            }
            return TypedResults.Ok(new BookResponseDTO(book));
        }

        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            var result = await bookRepository.DeleteBook(id);
            if (result)
            {
                return TypedResults.NoContent();
            }
            return TypedResults.NotFound();
        }
    }
}
