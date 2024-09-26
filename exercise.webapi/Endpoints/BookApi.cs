﻿using exercise.webapi.Models;
using exercise.webapi.Models.DTOs;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            app.MapGroup("/books");
            app.MapGet("/books", GetBooks);
            app.MapPost("/books{authorId}", AddBook);
            app.MapGet("/books/{Id}", GetBook);
            app.MapPost("/books/{bookId}", UpdateBook);
            app.MapDelete("/books/{Id}", DeleteBook);
        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = BookDTO.FromRepository(await bookRepository.GetAllBooks());
            return TypedResults.Ok(books);
        }

        private static async Task<IResult> GetBook(IBookRepository bookRepository, int Id) {
            var book = await bookRepository.GetBook(Id);
            return TypedResults.Ok(new BookDTO(book));
        }

        private static async Task<IResult> UpdateBook(IBookRepository bookRepository, int Id, BookUpdateDTO payload) {
            var book = await bookRepository.UpdateBook(Id, payload);
            return TypedResults.Ok(new BookDTO(book));
        }

        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int Id) {
            Book book = await bookRepository.DeleteBook(Id);
            return TypedResults.Ok(new BookDTO(book));
        }
        private static async Task<IResult> AddBook(IBookRepository bookRepository, int authorId, BookCreatePayload payload)
        {

            if (payload.Title == null || payload.Title.Length == 0) {
                return TypedResults.BadRequest("Book title is required");
            }

            if (payload.PublisherId == 0) {
                return TypedResults.BadRequest("Publisher ID is required");
            }

            Author author = await bookRepository.CreateBook(authorId, payload);
            return TypedResults.Ok(new AuthorResponseDTO(author));
        }
    }
}
