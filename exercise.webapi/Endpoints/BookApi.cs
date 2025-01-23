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
            app.MapGet("/books", GetBooks);
            app.MapGet("/books/{id}", GetBook);
            app.MapPut("/books/{id}", UpdateBook);
            app.MapDelete("/books/{id}", DeleteBook);
            app.MapPost("/books", AddBook);
        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            var bookDtos = books.Select(book => new BookDto(book));
            return TypedResults.Ok(bookDtos);
        }

        private static async Task<IResult> GetBook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetBook(id);
            if (book == null)
            {
                return Results.NotFound();
            }
            return TypedResults.Ok(new BookDto(book));
        }

        private static async Task<IResult> UpdateBook(IBookRepository bookRepository, int id, BookUpdateDto updates)
        {
            var book = await bookRepository.GetBook(id);
            if (book == null)
            {
                return Results.NotFound();
            }
            book.AuthorId = updates.AuthorId;
            book.Title = updates.Title;
            book.PublisherId = updates.PublisherId;

            await bookRepository.UpdateBook(book);
            Book updatedBook = await bookRepository.GetBook(book.Id);
            return TypedResults.Ok(new BookDto(updatedBook));
        }

        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            var success = await bookRepository.DeleteBook(id);
            if (!success)
            {
                return TypedResults.NotFound();
            }
            return TypedResults.Ok("Successfully deleted!");
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> AddBook(IBookRepository bookRepository, IAuthorRepository authorRepository, IPublisherRepository publisherRepository, BookUpdateDto bookUpdateDto)
        {
            var author = await authorRepository.GetAuthor(bookUpdateDto.AuthorId);
            var publisher = await publisherRepository.GetPublisher(bookUpdateDto.PublisherId);
            if (author == null || publisher == null)
            {
                return TypedResults.NotFound("Author or publisher not found");
            }
            if (string.IsNullOrWhiteSpace(bookUpdateDto.Title))
            {
                return TypedResults.BadRequest("Invalid title");
            }
            var book = new Book
            {
                AuthorId = bookUpdateDto.AuthorId,
                Title = bookUpdateDto.Title,
                PublisherId = bookUpdateDto.PublisherId,
                Publisher = publisher,
                Author = author
            };
            await bookRepository.AddBook(book);
            return TypedResults.Created($"https://localhost/7054/books/{book.Id}",new BookDto(book));

        }
    }
}
