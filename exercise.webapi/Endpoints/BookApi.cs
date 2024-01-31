using exercise.webapi.DTO.BookDTO;
using exercise.webapi.Models;
using exercise.webapi.Models.Payload;
using exercise.webapi.Repository.BookRepo;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            var books = app.MapGroup("/books");

            books.MapGet("", GetBooks);
            books.MapGet("/{id}", GetBookById);
            books.MapPatch("/{id}", UpdateBookByID);
            books.MapDelete("/{id}", DeleteBookByID);
            books.MapPost("/{id}", CreateABook);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetBookById(IBookRepository bookRepository, int bookID)
        {
            var book = await bookRepository.GetByIdAsync(bookID);
            if (book == null) { return TypedResults.NotFound($"Book ID:{bookID} not found"); }

            var result = new BookDTO(book);
            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var book = BookDTO.FromRepository(await bookRepository.GetAllBooksAsync());
            return book == null ? TypedResults.NotFound() : TypedResults.Ok(book);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> UpdateBookByID(IBookRepository bookRepository, int bookID, int newAuthorID)
        {
            var book = new BookDTO(await bookRepository.UpdateBookByIDAsync(bookID, newAuthorID));
            return book == null ? TypedResults.NotFound() : TypedResults.Ok(book);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> DeleteBookByID(IBookRepository bookRepository, int bookID)
        {
            var result = await bookRepository.DeleteABook(bookID);
            return result ? TypedResults.Ok("Book was successfully deleted") : TypedResults.NotFound("Book not found");
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> CreateABook(IBookRepository bookRepository, BookPayload payload)
        {
            Book book;
            try
            {
                book = bookRepository.CreateABook(payload).Result;
            }
            catch (Exception ex)
            {

                return TypedResults.NotFound(ex.Message);
            }

            return book == null ? TypedResults.BadRequest("Title can't be empty") :
                TypedResults.Created(
                    $"/books/{book.Id}",
                    new BookDTO(await bookRepository.GetByIdAsync(book.Id)));
        }
    }
}
