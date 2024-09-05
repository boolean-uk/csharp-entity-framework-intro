using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            var books = app.MapGroup("books");
            books.MapGet("/", GetBooks);
            books.MapGet("/{id}", GetBook);
            books.MapPut("/{id}", UpdateBook);
            books.MapDelete("/{id}", DeleteBook);
            books.MapPost("/", CreateBook);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            return TypedResults.Ok(books);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetBook(id);
            return TypedResults.Ok(book);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> UpdateBook(IBookRepository bookRepository, int id, BookUpdateModel model)
        {
            var result = await bookRepository.UpdateBook(id, model);
            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            var result = await bookRepository.DeleteBook(id);
            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> CreateBook(IBookRepository bookRepository, BookCreateModel model)
        {
            try
            {
                var result = await bookRepository.CreateBook(model);
                return TypedResults.Ok(result);
            }
            catch (Exception ex)
            {
                if (ex is KeyNotFoundException) return TypedResults.NotFound("Author not found");
                if (ex is ArgumentException) return TypedResults.BadRequest("No title was provided");
                else return TypedResults.BadRequest("Unknown Reason");
            }
        }
    }
}
