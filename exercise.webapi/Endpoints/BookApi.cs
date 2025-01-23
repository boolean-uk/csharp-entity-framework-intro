using System.Collections.Immutable;
using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using exercise.webapi.ViewModel;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            var book = app.MapGroup("books");
            book.MapGet("/", GetBooks);
            book.MapGet("/{id}", GetBook);
            book.MapPut("/{id}", UpdateBook);
            book.MapDelete("/{id}", DeleteBook);
            book.MapPost("/{id}", CreateBook);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetBook(id);
            var result = new BookDTO()
            {
                Id = book.Id,
                Title = book.Title,
                AuthorName = $"{book.Author.FirstName} {book.Author.LastName}",
                PublisherName = book.Publisher.Name
            };

            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            var result = new List<BookDTO>();

            foreach (var b in books)
            {
                var book = new BookDTO()
                {
                    Id = b.Id,
                    Title = b.Title,
                    AuthorName = $"{b.Author.FirstName} {b.Author.LastName}",
                    PublisherName = b.Publisher.Name
                };
                result.Add(book);

            }

            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> UpdateBook(IBookRepository bookRepository, int id, BookPut model)
        {
            try
            {
                var target = await bookRepository.GetBook(id);
                if (model.AuthorId != null) target.AuthorId = (int)model.AuthorId;
                if (model.PublisherId != null) target.PublisherId = (int)model.PublisherId;

                await bookRepository.UpdateBook(target);
                var update = await bookRepository.GetBook(id);
                var result = new BookDTO()
                {
                    Id = update.Id,
                    Title = update.Title,
                    AuthorName = $"{update.Author.FirstName} {update.Author.LastName}",
                    PublisherName = update.Publisher.Name
                };

                return TypedResults.Ok(result);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            try
            {
                var target = await bookRepository.GetBook(id);
                if (target == null) return TypedResults.NotFound("Book not found.");
                if (bookRepository.DeleteBook(id) != null)
                {
                    var result = new BookDTO()
                    {
                        Id = target.Id,
                        Title = target.Title,
                        AuthorName = $"{target.Author.FirstName} {target.Author.LastName}",
                        PublisherName = target.Publisher.Name
                    };
                    return TypedResults.Ok(result);
                }
                return TypedResults.NotFound("Book not found.");
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> CreateBook(IBookRepository bookRepository, IAuthorRepository authorRepository, IPublisherRepository publisherRepository, BookPost model)
        {
            try
            {
                if (string.IsNullOrEmpty(model.Title)) return TypedResults.BadRequest("Title is required.");
                if (model.AuthorId <= 0) return TypedResults.BadRequest("Valid AuthorId is required.");
                if (model.PublisherId <= 0) return TypedResults.BadRequest("Valid PublisherId is required.");
               
                var author = await authorRepository.GetAuthor(model.AuthorId);
                if (author == null) return TypedResults.NotFound("Author does not exist in database");
                var publisher = await publisherRepository.GetPublisher(model.PublisherId);
                if (publisher == null) return TypedResults.NotFound("Publiser does not exist in database");

                var newBook = await bookRepository.CreateBook(new Book(){ Title = model.Title, AuthorId = model.AuthorId, PublisherId = model.PublisherId});

                var createdBook = await bookRepository.GetBook(newBook.Id);

                BookDTO result = new BookDTO()
                {
                    Id = createdBook.Id,
                    Title = createdBook.Title,
                    AuthorName = $"{createdBook.Author.FirstName} {createdBook.Author.LastName}",
                    PublisherName = createdBook.Publisher.Name
                };
                return TypedResults.Created($"/{createdBook.Id}", result);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

    }
}
