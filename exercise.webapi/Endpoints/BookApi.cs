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
            app.MapPost("/books/{id}/authors/{authorId}", AddAuthorToBook);
            app.MapDelete("/books/{id}/authors/{authorId}", RemoveAuthorFromBook);
            //Get unavailable books, we might use queryparameters and the checkoutrepository
            app.MapGet("/books/unavailable", GetUnavailableBooks);
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

            //book.AuthorId = updates.AuthorId;
            if (!string.IsNullOrWhiteSpace(updates.Title))
                book.Title = updates.Title;
            if (updates.PublisherId != null)
                book.PublisherId = (int)updates.PublisherId;

            await bookRepository.UpdateBook(book);
            Book updatedBook = await bookRepository.GetBook(id);
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
            if (bookUpdateDto.PublisherId == null)
            {
                return TypedResults.BadRequest("PublisherId is required");
            }
            var publisher = await publisherRepository.GetPublisher((int)bookUpdateDto.PublisherId);
            if (publisher == null)
            {
                return TypedResults.NotFound();
            }
            var book = new Book
            {
                Title = bookUpdateDto.Title,
                PublisherId = (int)bookUpdateDto.PublisherId
            };
            await bookRepository.AddBook(book);
            return TypedResults.Created($"https://localhost/7054/books/{book.Id}", new BookDto(book));
        }

        private static async Task<IResult> AddAuthorToBook(IBookRepository bookRepository, IAuthorRepository authorRepository, IBookAuthorRepository bookAuthorRepository, int id, int authorId)
        {
            var book = await bookRepository.GetBook(id);
            var author = await authorRepository.GetAuthor(authorId);
            if (book == null || author == null)
            {
                return TypedResults.NotFound();
            }
            var BookAuthor = new BookAuthor
            {
                BookId = book.Id,
                AuthorId = author.Id
            };

            bookAuthorRepository.AddBookAuthor(BookAuthor);
            return TypedResults.Ok(new BookAuthorDto(book.Title, author.FirstName + author.LastName));
        }

        private static async Task<IResult> RemoveAuthorFromBook(IBookRepository bookRepository, IAuthorRepository authorRepository, IBookAuthorRepository bookAuthorRepository, int id, int authorId)
        {
            var book = await bookRepository.GetBook(id);
            var author = await authorRepository.GetAuthor(authorId);
            if (book == null || author == null)
            {
                return TypedResults.NotFound();
            }
            var bookAuthor = book.BookAuthors.FirstOrDefault(ba => ba.AuthorId == author.Id);
            if (bookAuthor == null)
            {
                return TypedResults.NotFound();
            }
            bookAuthorRepository.DeleteBookAuthor(bookAuthor.Id);
            return TypedResults.Ok();
        }

        private static async Task<IResult> GetUnavailableBooks(ICheckoutRepository checkoutRepository, IBookRepository bookRepository)
        {
            var checkouts = await checkoutRepository.GetAllCheckouts();
            var unavailableBooks = checkouts
                .Where(c => !c.IsReturned)
                .Select(c => new UnavailableDto
                {
                    Book = new BookDto(c.Book),
                    AvailableBy = c.DueDate,
                })
                .ToList();

            return TypedResults.Ok(unavailableBooks);
        }
    }
}
