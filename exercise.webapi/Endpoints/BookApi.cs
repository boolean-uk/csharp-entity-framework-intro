using exercise.webapi.Models;
using exercise.webapi.Models.BaseModels;
using exercise.webapi.Models.DataTransfer;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookAPI
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            app.MapGet("/books", GetBooks);
            app.MapGet("/{id}", GetBook);
            app.MapPut("/{id}", UpdateBook);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAll();
            List<BookDTO> results = new List<BookDTO>();
            foreach (var book in books)
            {
                AuthorDTO authorData = new AuthorDTO(book.Author.FirstName, book.Author.LastName, book.Author.Email);
                BookDTO bookData = new BookDTO(book.Title, authorData);
                results.Add(bookData);
            }
            return TypedResults.Ok(results);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.Get(id);
            AuthorDTO authorData = new AuthorDTO(book.Author.FirstName, book.Author.LastName, book.Author.Email);
            BookDTO result = new BookDTO(book.Title, authorData);
            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> UpdateBook(IBookRepository bookRepository, int id, string title, AuthorDTO authorData)
        {
            Book book = await bookRepository.Get(id);
            book.Title = title;
            book.Author.FirstName = authorData.FirstName;
            book.Author.LastName = authorData.LastName;
            book.Author.Email = authorData.Email;
            var result = bookRepository.Update(book);
            return TypedResults.Created(id.ToString(), result);
        }
    }
}
