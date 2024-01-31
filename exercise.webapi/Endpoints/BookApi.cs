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
            app.MapGet("/books", GetBooks);
            app.MapGet("/books/{id}", GetBook);
            app.MapPut("/books/{id}", UpdateBook);
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
    }
}
