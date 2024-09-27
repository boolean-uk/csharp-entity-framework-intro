using exercise.webapi.Repository;
using exercise.webapi.DTO;
using exercise.webapi.Models;
using static System.Reflection.Metadata.BlobBuilder;
using Microsoft.AspNetCore.Mvc;
namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            app.MapGet("/books", GetBooks);
            app.MapGet("/books/{id}", GetBookById);
            app.MapPost("/books", AddBook);
            app.MapPut("/books/{id}", UpdateBook);
            app.MapDelete("/books/{id}", DeleteBook);
        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {            
            
            var books = await bookRepository.GetAllBooks();      
            return TypedResults.Ok(BookResponseDto.FromRepository(books));
        }

        private static async Task<IResult> GetBookById(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetBookById(id);
            if (book == null)
            {
                return Results.NotFound();
            }
            return TypedResults.Ok(new BookResponseDto(book));
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
       private static async Task<IResult> AddBook(IBookRepository bookRepository, BookPostPayload book)
        {
            var newBook = await bookRepository.AddBook(book.Title, book.AuthorId);
            if (newBook == null)
            {
                return Results.NotFound();
            }
            return TypedResults.Ok(new BookResponseDto(newBook));
        }

        private static async Task<IResult> UpdateBook(IBookRepository bookRepository, int id, BookUpdatePayload book)
        {
            var updatedBook = await bookRepository.UpdateBook(id, book.AuthorId);
            if (updatedBook == null)
            {
                return Results.NotFound();
            }
            return TypedResults.Ok(new BookResponseDto(updatedBook));
        }

        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.DeleteBook(id);
            if (book == null)
            {
                return Results.NotFound();
            }
            return TypedResults.Ok(book);
        }
    }
}

