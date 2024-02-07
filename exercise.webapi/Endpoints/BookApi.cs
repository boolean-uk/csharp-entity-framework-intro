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
            var group = app.MapGroup("books");
            group.MapGet("/", GetBooks);
            group.MapGet("/{id}", GetBook);
            group.MapPut("/{id}", UpdateBook);
            group.MapDelete("/{id}", DeleteBook);
            group.MapPost("/", CreateBook);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            List<BookDto> bookDtos = books.Select(b => b.ToDto()).ToList();
            return TypedResults.Ok(bookDtos);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetBook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetBook(id);
            return book == null ? TypedResults.NotFound() : TypedResults.Ok(book.ToDto());
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> UpdateBook(IBookRepository bookRepository, int id, int authorId)
        {
            var author = bookRepository.GetAuthor(authorId);
            var book = await bookRepository.GetBook(id);
            if (book == null || author == null) return TypedResults.NotFound();

            book.Update(author.Result);
            return TypedResults.Ok(book.ToDto());
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            if (await bookRepository.GetBook(id) == null) return TypedResults.NotFound();

            var book = await bookRepository.GetBook(id);
            if (book == null) return TypedResults.NotFound();

            await bookRepository.DeleteBook(book);
            return TypedResults.Ok(book.ToDto());
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> CreateBook(IBookRepository bookRepository, BookParams book)
        {
            var author = await bookRepository.GetAuthor(book.AuthorId);
            if (author == null) return TypedResults.NotFound();

            if (!book.Title.Any()) return TypedResults.BadRequest();

            Book newBook = await bookRepository.CreateBook(new Book() { Title = book.Title, AuthorId = book.AuthorId });
            return TypedResults.Ok(newBook.ToDto());
        }
    }
}
