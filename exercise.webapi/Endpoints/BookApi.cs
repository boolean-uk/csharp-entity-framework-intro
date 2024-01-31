using exercise.webapi.DTOs;
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
            var group = app.MapGroup("/books");

            group.MapGet("/", GetBooks);
            group.MapGet("/{id}", GetBook);
            group.MapPut("/{id}", UpdateBook);
            group.MapDelete("/{id}", DeleteBook);
            group.MapPost("/", CreateBook);
        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            return TypedResults.Ok(books);
        }

        private static async Task<IResult> GetBook(IBookRepository bookRepository, int id)
        {
            try
            {
                var book = await bookRepository.GetBookById(id);
                return TypedResults.Ok(book);
            } catch (ArgumentException ex) 
            {
                return TypedResults.NotFound(ex.Message);
            }
        }

        private static async Task<IResult> UpdateBook(IBookRepository bookRepository, int bookId, int authorId)
        {
            try
            {
                return TypedResults.Ok(await bookRepository.UpdateBookAuthor(bookId, authorId));
            } catch (ArgumentException ex)
            {
                return TypedResults.NotFound(ex.Message);
            }
        }

        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int bookId)
        {
            try
            {
                return TypedResults.Ok(await bookRepository.DeleteBookById(bookId));
            } catch (ArgumentException ex)
            {
                return TypedResults.NotFound(ex.Message);
            }
        }

        private static async Task<IResult> CreateBook(IBookRepository bookRepository, CreateBookDTO dto)
        {
            try
            {
                return TypedResults.Created(nameof(CreateBook), await bookRepository.CreateBook(dto));
            } catch (ArgumentException ex)
            {
                return TypedResults.NotFound(ex.Message);
            } catch (BadHttpRequestException ex)
            {
                return TypedResults.BadRequest(ex.Message);
            }
        }
    }
}
