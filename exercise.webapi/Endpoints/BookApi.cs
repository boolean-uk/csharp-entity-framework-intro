using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            var books = app.MapGroup("books");
            books.MapGet("/", GetBooks);
            books.MapGet("/{id}", GetBook);
            books.MapPut("/{id}/{authorId}", UpdateBook);
            books.MapDelete("/delete/{id}", DeleteBook);
            books.MapPost("/create", CreateBook);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            return TypedResults.Ok(books);
        }
        
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetBook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetBookById(id);
            if (book == null)
            {
                return TypedResults.NotFound();
            }
            return TypedResults.Ok(book);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> UpdateBook(IBookRepository bookRepository, int id, int authorId)
        {
            var book = await bookRepository.UpdateBook(id, authorId);
            BookDTO updatedBook = new BookDTO()
            {
                Id = id,
                Title = book.Title,
                AuthorName = $"{book.Author.FirstName} {book.Author.LastName}"
            };
            return TypedResults.Ok(updatedBook);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.DeleteBook(id);
            if (book == null)
            { return TypedResults.NotFound(); }
            return TypedResults.Ok(book);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> CreateBook(IBookRepository bookRepository, BookDTO model)
        {
            var book = await bookRepository.CreateBook(model);
            return TypedResults.Ok(book);
        }
    }
}
