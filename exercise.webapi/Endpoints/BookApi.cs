using exercise.webapi.Models;
using exercise.webapi.Repository;
using exercise.webapi.DTOs;
using static System.Reflection.Metadata.BlobBuilder;
using Microsoft.Extensions.Hosting;
using static exercise.webapi.Repository.IAuthorRepository;
using Microsoft.AspNetCore.Mvc;
using static exercise.webapi.DTOs.payloads;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {

        public static void ConfigureBooksApi(this WebApplication app)
        {
            var books = app.MapGroup("books");
            books.MapGet("/", GetBooks);
            books.MapGet("/{Id}", GetABook);
            books.MapPut("/{bookId}/", UpdateBook);
            books.MapDelete("/{Id}", DeleteBook);
            books.MapPost("/{Id}", CreateBook);
        }

      
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetBooks(IBookRepository repository)
        {
            var books = await repository.GetAllBooks();
            var bookDto = new List<BookResponseDTO>();
            foreach (Book book in books)
            {
                bookDto.Add(new BookResponseDTO(book));
            }
            return TypedResults.Ok(bookDto);
        }


        private static async Task<IResult> GetABook(int bookId, IBookRepository bookRepository)
        {
            var book = await bookRepository.GetBook(bookId);
            if (book == null)
            {
                return TypedResults.NotFound("Book not found");
            }

            return TypedResults.Ok(new BookResponseDTO(book));

        }


        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> UpdateBook(int bookId, UpdateBookPayload payload, IBookRepository booksRepository)
        { 
            Book? book = await booksRepository.GetBook(bookId);
            if (book == null)
            {
                return TypedResults.NotFound("Book was not found");
            }
            Book? bookUpdated = await booksRepository.UpdateBook(bookId, payload.newTitle);
            if (bookUpdated == null)
            {
                return Results.BadRequest("Failed to update book.");
            }
            return TypedResults.Ok(new BookResponseDTO(book));
        }

        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> DeleteBook(int bookId, IBookRepository repository)
        {
            Book? book = await repository.GetBook(bookId);
            if (book == null)
            {
                return TypedResults.NotFound("Book not found");
            }
            Book? bookDelete = await repository.DeleteBook(bookId);
            if (bookDelete == null)
            {
                return Results.BadRequest("Failed to delete book.");
            }

            return TypedResults.Ok(new BookResponseDTO(book));
        }


        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateBook(CreateBookPayload payload, IBookRepository repository)
        {
            if (payload.Title == null || payload.Title == "")
            {
                return Results.BadRequest("A non-empty Name is required");
            }

            Book? book = await repository.CreateBook(payload.Title);
            if (book == null)
            {
                return Results.BadRequest("Failed to create book.");
            }

            return TypedResults.Created($"/books/{book.Id}", new BookResponseDTO(book));
        }

    }
}
