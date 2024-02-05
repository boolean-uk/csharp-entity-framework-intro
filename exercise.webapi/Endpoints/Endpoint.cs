using exercise.webapi.Models;
using exercise.webapi.Models.DatabaseModels;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class Endpoint
    {
        public static void ConfigureEndpoint(this WebApplication app)
        {
            var booksGroup = app.MapGroup("books");

            booksGroup.MapGet("/", GetBooks);
            booksGroup.MapGet("/{id}", GetBook);
            booksGroup.MapPut("/{id}", UpdateBook);
            booksGroup.MapDelete("/{id}", DeleteBook);
            booksGroup.MapPost("/", CreateBook);

            var authorsGroup = app.MapGroup("authors");

            authorsGroup.MapGet("/", GetAuthors);
            authorsGroup.MapGet("/{id}", GetAuthor);
        }

        //Book API
        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            return TypedResults.Ok(books);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBook(IBookRepository bookRepository, int id) { 
            var book = await bookRepository.GetBook(id);
            return TypedResults.Ok(book);

        }
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateBook(IBookRepository bookRepository, int id, BookAuthorPut model)
        {
            var entities = await bookRepository.GetAllBooks();
            if(!entities.Any(x => x.Id == id))
            {
                return TypedResults.NotFound("Book not found");
            }
            var book = await bookRepository.GetBook(id);

            book.AuthorId = model.AuthorId != null ? model.AuthorId : book.AuthorId;

            bookRepository.UpdateBookAuthor(id, book);

            return TypedResults.Created($"/{book.Id}", book);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            var entities = await bookRepository.GetAllBooks();
            if (!entities.Any(x => x.Id == id))
            {
                return TypedResults.NotFound("Book not found");
            }

            var book = await bookRepository.DeleteBook(id);
            return TypedResults.Ok(book);
        }
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        private static async Task<IResult> CreateBook(IBookRepository bookRepository, Book book)
        {
            var authorEntries = await bookRepository.GetAllAuthors();
            var publisherEntries = await bookRepository.GetAllPublishers();
            if (!authorEntries.Any(a => a.Id == book.AuthorId))
            {
                return TypedResults.NotFound("Author not found");
            }

            var bookEntries = await bookRepository.GetAllBooks();
            if (authorEntries.Any(a => a.Id == book.Id))
            {
                return TypedResults.BadRequest("Book already exists");
            }

            book.Author = authorEntries.FirstOrDefault(a => a.Id == book.AuthorId);
            book.Publisher = publisherEntries.FirstOrDefault(p => p.Id == book.PublisherId);

            await bookRepository.CreateBook(book);
            return TypedResults.Ok(book);
        }

        //Author API
        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAuthors(IBookRepository bookRepository)
        {
            var authors = await bookRepository.GetAllAuthors();
            return TypedResults.Ok(authors);


        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAuthor(IBookRepository bookRepository, int id)
        {
            var author = await bookRepository.GetAuthor(id);
            return TypedResults.Ok(author);

        }

    }
}
