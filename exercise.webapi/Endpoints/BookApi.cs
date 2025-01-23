using exercise.webapi.DTOs;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            app.MapPost("/books", CreateBook);
            app.MapGet("/books", GetBooks);
            app.MapGet("/books/{id}", GetBookById);
            app.MapPut("/books/{id}", UpdateBookAuthorById);
            app.MapDelete("/books/{id}", DeleteBookById);
        }

        private static async Task<IResult> CreateBook(IBookRepository bookRepository, CreateBookDTO bookDto)
        {
            try
            {
                var createdBook = await bookRepository.CreateBook(bookDto);
                return Results.Created($"/books/{createdBook.Id}", createdBook);
            }
            catch (KeyNotFoundException ex)
            {
                return Results.NotFound(new { message = ex.Message });
            }
            catch (ArgumentException ex)
            {
                return Results.BadRequest(new { message = ex.Message });
            }
        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            return Results.Ok(books);
        }

        private static async Task<IResult> GetBookById(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetBookById(id);
            return Results.Ok(book);
        }

        private static async Task<IResult> UpdateBookAuthorById(IBookRepository bookRepository, int id, int authorId)
        {
            var updatedBook = await bookRepository.UpdateBookAuthorById(id, authorId);
            return Results.Ok(new { message = "Updated", book = updatedBook});
        }

        private static async Task<IResult> DeleteBookById(IBookRepository bookRepository, int id)
        {
            try
            {
                await bookRepository.DeleteBookById(id);
                return Results.Ok(new { message = $"Deleted book with id '{id}'"});
            }
            catch (KeyNotFoundException ex)
            {
                return Results.BadRequest( new { message = $"No book with id '{id}' found"});
            }
        }
    }
}
