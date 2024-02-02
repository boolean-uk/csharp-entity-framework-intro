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
            group.MapGet("/", GetAll);
            group.MapGet("/{id}", Get);
            group.MapPut("/{id}", Update);
            group.MapDelete("/{id}", Delete);
            group.MapPost("/", Create);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAll(IRepository<Book> bookRepository)
        {
            var books = await bookRepository.GetAll();
            List<BookWithAuthorDTO> results = new List<BookWithAuthorDTO>();
            foreach (var book in books)
            {
                results.Add(new BookWithAuthorDTO(book));
            }
            return TypedResults.Ok(results);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> Get(IRepository<Book> bookRepository, int id)
        {
            var book = await bookRepository.Get(id);
            return TypedResults.Ok(new BookWithAuthorDTO(book));
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> Update([FromServices] IRepository<Book> bookRepository, [FromServices] IRepository<Author> authorRepository, [FromRoute] int id, [FromBody] BookCreateDTO inputData)
        {
            if (!authorRepository.IsAnExistingID(inputData.AuthorID).Result) return TypedResults.NotFound($"Could not find author with ID {inputData.AuthorID}");
            Book book = await bookRepository.Get(id);
            if (book == null) return TypedResults.NotFound($"Could not find book with ID {id}");
            book.Title = inputData.Title;
            book.AuthorID = inputData.AuthorID;
            var result = bookRepository.Update(book);
            return TypedResults.Created(id.ToString(), new BookWithAuthorDTO(book));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> Delete(IRepository<Book> bookRepository, int id)
        {
            var result = await bookRepository.Delete(id);
            return TypedResults.Ok(new BookDTO(result));
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> Create([FromServices] IRepository<Book> bookRepository, [FromServices] IRepository<Author> authorRepository, [FromBody] BookCreateDTO bookData)
        {
            if (!authorRepository.IsAnExistingID(bookData.AuthorID).Result) return TypedResults.NotFound($"Could not find author with ID {bookData.AuthorID}");
            if (!(bookData.Title.Length > 0)) return TypedResults.BadRequest("Data input does not meet requirements");
            Book newBook = new Book(){ Title = bookData.Title, AuthorID = bookData.AuthorID };
            var result = await bookRepository.Insert(newBook);
            return TypedResults.Created(newBook.ID.ToString(), new BookWithAuthorDTO(result));
        }


    }
}
