using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
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
            books.MapPost("/", CreateBook);
            app.MapPut("/{id}", UpdateBook);
            app.MapDelete("/{id}", DeleteBook);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            return TypedResults.Ok(books);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> GetBook(IBookRepository bookRepository, int id)
        {
            DTOBook book = await bookRepository.GetBookById(id);
            return book != null ? TypedResults.Ok(book) : TypedResults.BadRequest();

        }

        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> UpdateBook(IBookRepository bookRepository, int id, int authorId)
        {
            DTOBook book = await bookRepository.UpdateById(id, authorId);
            return book != null ? TypedResults.Ok(book) : TypedResults.BadRequest();

        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {

            DTOBook book = bookRepository.DeleteById(id);
            return book != null ? TypedResults.Ok(book) : TypedResults.BadRequest();

        }

       

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> CreateBook(IBookRepository bookRepository, DTOBook book)
        {
            var addedBook = await bookRepository.AddBook(book);
            if (addedBook != null)
            {
                return TypedResults.Ok(addedBook);
            }
            else
            {
                return TypedResults.NotFound("Could not find author");
            }

        }




    }
}
