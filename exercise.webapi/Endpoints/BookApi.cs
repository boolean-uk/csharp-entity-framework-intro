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
            books.MapGet("/{id}", GetSingleBook);
            books.MapPost("/", CreateBook);
            books.MapPut("/{id}", UpdateBook);
            books.MapDelete("/{id}", DeleteBook);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            return TypedResults.Ok(books);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetSingleBook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetBookById(id);
            if (book == null)
            {
                return TypedResults.NotFound();
            }

            return TypedResults.Ok(book);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> CreateBook(
            IBookRepository bookRepository,
            IAuthorRepository authorRepository,
            IPublisherRepository publisherRepository,
            BookPostDTO bookDto)
        {
            if (bookDto == null)
            {
                return Results.BadRequest("Invalid book object");
            }

            // Check author
            var author = await authorRepository.GetAuthorById(bookDto.AuthorId);
            if (author == null)
            {
                return Results.NotFound($"Author with ID {bookDto.AuthorId} not found");
            }

            // Check publisher
            var publisher = await publisherRepository.GetPublisherById(bookDto.PublisherId);
            if (publisher == null)
            {
                return Results.NotFound($"Publisher with ID {bookDto.PublisherId} not found");
            }

            // Create book
            var newBook = new Book
            {
                Title = bookDto.Title,
                AuthorId = bookDto.AuthorId,
                PublisherId = bookDto.PublisherId

            };

            var createdBook = await bookRepository.AddBook(newBook);
            return Results.Created($"/books/{createdBook.Id}", createdBook);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateBook(
            IBookRepository bookRepository,
            IAuthorRepository authorRepository,
            IPublisherRepository publisherRepository,
            int id,
            BookPutDTO bookDto)
        {
            // Find existing book
            var existingBook = await bookRepository.GetBookByIdAsModel(id);
            if (existingBook == null)
            {
                return Results.NotFound($"Book with ID {id} not found");
            }

            // Retrieve author of book
            var author = await authorRepository.GetAuthorById(bookDto.AuthorId);
            if (author == null)
            {
                return Results.NotFound($"Author with ID {bookDto.AuthorId} not found");
            }

            // Retrieve publisher of book
            var publisher = await publisherRepository.GetPublisherById(bookDto.PublisherId);
            if (publisher == null)
            {
                return Results.NotFound($"Publisher with ID {bookDto.PublisherId} not found");
            }

            // Update book
            existingBook.AuthorId = bookDto.AuthorId;
            existingBook.PublisherId = bookDto.PublisherId;

            var updatedBook = await bookRepository.UpdateBook(id, existingBook);

            return Results.Created($"/books/{id}", updatedBook);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetBookById(id);
            if (book == null)
            {
                return TypedResults.NotFound();
            }

            await bookRepository.DeleteBook(id);

            return TypedResults.Ok(book);
        }
    }
}
