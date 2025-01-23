using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Payload;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            var books = app.MapGroup("/books");
            books.MapGet("/", GetBooks);
            books.MapGet("/{id}", GetBook);
            books.MapPut("/{id}", UpdateAuthor);
            books.MapDelete("/{id}", DeleteBook);
            books.MapPost("/", CreateBook);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            Payload<IEnumerable<BookDTO>> payload  = await bookRepository.GetAllBooks();
            return TypedResults.Ok(payload.Data);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetBook(IBookRepository bookRepository, int id)
        {
            Payload<BookDTO> payload = await bookRepository.GetBook(id);
            if (!payload.GoodResponse)
            {
                return TypedResults.NotFound(payload.Message);
            }

            return TypedResults.Ok(payload.Data);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> UpdateAuthor(IBookRepository bookRepository, int bookId, AuthorPostDTO authorPost)
        {
            Payload<BookDTO> payload = await bookRepository.UpdateAuthor(bookId, authorPost);

            if (!payload.GoodResponse)
            {
                return TypedResults.NotFound(payload.Message);
            }

            return TypedResults.Ok(payload.Data);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            Payload<BookDTO> payload = await bookRepository.DeleteBook(id);

            if (!payload.GoodResponse)
            {
                return TypedResults.NotFound(payload.Message);
            }

            return TypedResults.Ok(payload.Data);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> CreateBook(IBookRepository bookRepository, CreateBookDTO createBookDTO)
        {
            Payload<BookDTO> payload = await bookRepository.CreateBook(createBookDTO);

            if (!payload.GoodResponse)
            {
                return TypedResults.NotFound(payload.Message);
            }

            return TypedResults.Ok(payload.Data);


        }
    }
}
