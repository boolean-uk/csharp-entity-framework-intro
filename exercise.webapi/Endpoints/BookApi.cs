using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Internal;
using System.Linq;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            var group = app.MapGroup("books");
            app.MapGet("/books", GetBooks);
            app.MapGet("/books{id}", GetBookById);
            app.MapPut("/books{id},{authorId}", UpdateBook);
            app.MapPost("/books{authorId},{title}", CreateBook);
            app.MapDelete("/books{id}", DeleteBook);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBooks(IBookRepository repository)
        {
            var books = await repository.GetAllBooks();
            return TypedResults.Ok(books);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetBookById(IBookRepository repository, int id)
        {
            var book = await repository.GetById(id);
            if (book == null)
            {
                return TypedResults.NotFound();
            }
            return TypedResults.Ok(book);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> UpdateBook(IBookRepository repository, int id, int authorId)
        {
            if (repository.GetById(id) == null)
            {
                return TypedResults.NotFound();
            }

            var book = await repository.Update(id, authorId);

            BookDto newBook = new BookDto()
            {
                Id = id,
                Title = book.Title,
                AuthorId = book.AuthorId,
                AuthorName = $"{book.Author.FirstName} {book.Author.LastName}"
            };

            return TypedResults.Created($"/{newBook.Id}", newBook);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> DeleteBook(IBookRepository repository, int id)
        {
            var book = repository.Delete(id);
            if (book == null)
            {
                return TypedResults.NotFound();
            }
            return TypedResults.Ok(book);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> CreateBook(IBookRepository repository, IAuthorRepository authorRepository,
            BookPost newBook, int authorId)
        {
            var authors = await authorRepository.GetAllAuthors();
            if (!authors.Any(a => a.Id == authorId))
            {
                return TypedResults.NotFound("Author Id is not valid");
            }
            if (newBook.Title == null)
            {
                return TypedResults.BadRequest("Book Title must not be empty");
            }

            var book = await repository.Create(newBook, authorId);

            var response = new BookDto()
            {
                Id = book.Id,
                Title = book.Title,
                AuthorId = book.AuthorId,
                AuthorName = $"{book.Author.FirstName} {book.Author.LastName}"
            };

            return TypedResults.Created($"/{response.Id}", response);
        }
    }
}
