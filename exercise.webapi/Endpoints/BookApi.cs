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
            var books = app.MapGroup("/books");
            books.MapGet("/", GetBooks);
            books.MapPost("/", CreateBook);
            books.MapGet("/{id}", GetBook);
            books.MapPut("/{id}", UpdateBook);
            books.MapDelete("/{id}", DeleteBook);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> DeleteBook(HttpContext context, IBookRepository bookRepository, int id)
        {
            try
            {
                var b = await bookRepository.DeleteBook(id);
                return TypedResults.Ok(new Book_get(b));
            }
            catch (Exception ex)
            {
                return TypedResults.NotFound("Invalid book data");
            }
        }
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> UpdateBook(HttpContext context, IBookRepository bookRepository, IAuthorRepository authorRepository, IPublisherRepository publisherRepository, int id, Book_update dto)
        {
            try
            {
                var author = await authorRepository.GetAuthor(dto.AuthorId);
                if (author == null) return TypedResults.NotFound($"Book can't be updated to use AuthorId[{dto.AuthorId}], as no Author was found");
                var book = await bookRepository.GetBook(id);
                if (book == null) return TypedResults.NotFound($"Book can't be updated, no book with id[{id}] exists");
                var b = await bookRepository.UpdateBook(id, author);

                var url = $"{context.Request.Scheme}://{context.Request.Host}{context.Request.Path}";
                return TypedResults.Created($"{url}/{b.Id}", new Book_get(b));
            }
            catch (Exception ex)
            {
                return TypedResults.BadRequest("Invalid book data");
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> CreateBook(HttpContext context, IBookRepository bookRepository, IAuthorRepository authorRepository, IPublisherRepository publisherRepository, Book_create dto)
        {
            try
            {
                var author = await authorRepository.GetAuthor(dto.AuthorId);
                if (author == null)return TypedResults.NotFound($"Book can't be created with AuthorId[{dto.AuthorId}], as no Author was found");
                var publisher = await publisherRepository.GetPublisher(dto.PublisherId);
                if (publisher == null) return TypedResults.NotFound($"Book can't be created with PublisherId[{dto.PublisherId}], as no Publisher was found");
                var b = await bookRepository.CreateBook(dto.Title, dto.AuthorId, author, dto.PublisherId, publisher );
                
                var url = $"{context.Request.Scheme}://{context.Request.Host}{context.Request.Path}";
                return TypedResults.Created($"{url}/{b.Id}", new Book_get(b));
            }
            catch (Exception ex)
            {
                return TypedResults.BadRequest("Invalid book data");
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)] 
        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            if (books.Count() == 0) return TypedResults.NotFound($"No books found in the database");
            return TypedResults.Ok(books.Select(x => new Book_get(x)).ToList());
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetBook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetBook(id);
            if (book== null) return TypedResults.NotFound($"No book with id[{id}] exists");
            return TypedResults.Ok(new Book_get(book));
        }
    }
}
