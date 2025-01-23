using System;
using exercise.webapi.DTO;
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
            var books = app.MapGroup("books");

            app.MapGet("/", GetBooks);
            app.MapGet("/{id}", GetBook);
            app.MapPut("/{id}", UpdateBook);
            app.MapDelete("/{id}", DeleteBook);
            app.MapPost("/", AddBook);
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
        private static async Task<IResult> UpdateBook(IBookRepository bookRepository, int id, int newAuthorId)
        {
            return TypedResults.Ok(await bookRepository.UpdateBook(id, newAuthorId));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            return TypedResults.Ok(await bookRepository.DeleteBook(id));
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> AddBook(IBookRepository bookRepository, BookPost book)
        {
            Book bk = new Book()
            {
                Title = book.Title,
                AuthorId = book.AuthorId
            };
            await bookRepository.AddBook(bk);

            return TypedResults.Created($"https://localhost:7010/books/{bk.Id}", bk);
        }
    }
}
