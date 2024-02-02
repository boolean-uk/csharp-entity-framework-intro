using exercise.webapi.Models;
using exercise.webapi.Models.BaseModels;
using exercise.webapi.Models.DataTransfer.Author;
using exercise.webapi.Models.DataTransfer.Book;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookAPI
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
        private static async Task<IResult> GetBooks(IRepository<Book> bookRepository)
        {
            var books = await bookRepository.GetAll();
            List<BookOutputDTO> results = new List<BookOutputDTO>();
            foreach (var book in books)
            {
                AuthorDTO authorData = new AuthorDTO(book.Author.FirstName, book.Author.LastName, book.Author.Email);
                BookOutputDTO bookData = new BookOutputDTO(book.Title, authorData);
                results.Add(bookData);
            }
            return TypedResults.Ok(results);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBook(IRepository<Book> bookRepository, int id)
        {
            var book = await bookRepository.Get(id);
            AuthorDTO authorData = new AuthorDTO(book.Author.FirstName, book.Author.LastName, book.Author.Email);
            BookOutputDTO result = new BookOutputDTO(book.Title, authorData);
            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> UpdateBook([FromServices] IRepository<Book> bookRepository, [FromServices] IRepository<Author> authorRepository, [FromRoute] int id, [FromBody] BookInputDTO bookData)
        {
            if (!authorRepository.IsAnExistingID(bookData.AuthorID).Result)
            {
                return TypedResults.NotFound($"Could not find author with ID {bookData.AuthorID}");
            }
            Book book = await bookRepository.Get(id);
            if (book == null) return TypedResults.NotFound($"Could not find book with ID {id}");
            book.Title = bookData.Title;
            book.AuthorID = bookData.AuthorID;
            var result = bookRepository.Update(book);
            return TypedResults.Created(id.ToString(), new BookResultDTO(book));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> DeleteBook(IRepository<Book> bookRepository, int id)
        {
            var result = await bookRepository.Delete(id);
            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> CreateBook([FromServices] IRepository<Book> bookRepository, [FromServices] IRepository<Author> authorRepository, [FromBody] BookInputDTO bookData)
        {
            if (!authorRepository.IsAnExistingID(bookData.AuthorID).Result) return TypedResults.NotFound($"Could not find author with ID {bookData.AuthorID}");
            if (!(bookData.Title.Length > 0)) return TypedResults.BadRequest("Data input does not meet requirements");
            Book newBook = new Book(){ Title = bookData.Title, AuthorID = bookData.AuthorID };
            var result = await bookRepository.Insert(newBook);
            return TypedResults.Created(newBook.ID.ToString(), new BookResultDTO(newBook));
        }


    }
}
