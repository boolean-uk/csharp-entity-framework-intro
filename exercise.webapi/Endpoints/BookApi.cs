using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using exercise.webapi.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Net.Sockets;
using System;
using static System.Reflection.Metadata.BlobBuilder;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {

        public static void ConfigureBooksApi(this WebApplication app)
        {
            Service service = new Service();

            var bookGroup = app.MapGroup("books");
            bookGroup.MapGet("/", GetBooks);
            bookGroup.MapGet("{id}", GetBook);
            bookGroup.MapPost("{book}", CreateBook);
            bookGroup.MapPut("{id}", UpdateBook);
            bookGroup.MapDelete("{id}", DeleteBook);
        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            return TypedResults.Ok(books);
        }

        private static async Task<IResult> GetBook(IBookRepository bookRepository, int id)
        {
            var book = bookRepository.GetBook(id);
            Service service = new Service();
            BookDetailsDTO result = service.CreateBookDetailsDTO(book.Result.Item1, book.Result.Item2);

            return TypedResults.Ok(result);
        }
        private static async Task<IResult> UpdateBook(IBookRepository bookRepository, int bookID, int newAuthor)
        {
            var book = await bookRepository.UpdateBook(bookID, newAuthor);
            Service service = new Service();
            BookDetailsDTO result = service.CreateBookDetailsDTO(book.Item1, book.Item2);

            return TypedResults.Ok(book);
        }
        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            Book books = await bookRepository.DeleteBook(id);
            return TypedResults.Ok(books);
        }
        private static async Task<IResult> CreateBook(IBookRepository bookRepository, Book newBook)
        {
            var books = bookRepository.CreateBook(newBook);
            // Post book + author
            if(books.Result.Item1 == default(Book))
                return TypedResults.BadRequest();

            if (books.Result.Item2 == default(Author))
                return TypedResults.NotFound();

            return TypedResults.Ok(books);
        }
    }
}
