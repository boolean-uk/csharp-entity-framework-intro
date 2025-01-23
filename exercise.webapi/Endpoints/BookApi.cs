using System;
using System.Security.Principal;
using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;
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
            books.MapPost("/", AddBook);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            try
            {
                var books = await bookRepository.GetAllBooks();

                var bks = books.Select(book =>
                {
                    return new BookGet(
                    book.Id,
                    book.Title,
                    new AuthorInternal(
                        book.Author.Id,
                        book.Author.FirstName,
                        book.Author.LastName,
                        book.Author.Email
                        )
                    );
                });

                return TypedResults.Ok(bks);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBook(IBookRepository bookRepository, int id)
        {
            try
            {
                var book = await bookRepository.GetBook(id);

                BookGet bk = new BookGet(
                    book.Id,
                    book.Title,
                    new AuthorInternal(
                        book.Author.Id,
                        book.Author.FirstName,
                        book.Author.LastName,
                        book.Author.Email
                        )
                    );

                return TypedResults.Ok(bk);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> UpdateBook(IBookRepository bookRepository, int id, int newAuthorId)
        {
            try
            {
                return TypedResults.Ok(await bookRepository.UpdateBook(id, newAuthorId));
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            try
            {
                return TypedResults.Ok(await bookRepository.DeleteBook(id));
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> AddBook(IBookRepository bookRepository, IAuthorRepository authorRepository, BookPost book)
        {
            try
            {
                if (await authorRepository.GetAuthor(book.AuthorId) == null)
                    return TypedResults.NotFound("Author not found.");

                Book bk = new Book()
                {
                    Title = book.Title,
                    AuthorId = book.AuthorId
                };
                await bookRepository.AddBook(bk);

                return TypedResults.Created($"https://localhost:7054/books/{bk.Id}", bk);
            }
            catch (Exception ex)
            {
                return TypedResults.BadRequest(ex.Message);
            }
        }
    }
}
