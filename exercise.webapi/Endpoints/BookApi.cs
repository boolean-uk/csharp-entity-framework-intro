using System.ComponentModel.DataAnnotations;
using exercise.webapi.Dto;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            app.MapGet("/books", GetBooks);
            app.MapGet("/books/{id}", GetBook);
            app.MapPost("/books", CreateBook);
            app.MapDelete("/books/{id}", DeleteBook);
            app.MapPut("/books/{id}", UpdateBook);
        }

        [ProducesResponseType(typeof(IEnumerable<BookResponse>), StatusCodes.Status200OK)]
        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            var response = books.Select(b => new BookResponse(b));

            foreach (var book in books)
            {
                book.Author.Books = new List<Book>();
            }
            return TypedResults.Ok(response);
        }
        
        [ProducesResponseType(typeof(BookResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetBook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetBookById(id);
            if (book == null)
            {
                return TypedResults.NotFound();
            }
            book.Author.Books = new List<Book>();
            return TypedResults.Ok(new BookResponse(book));
        }
        
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetBookById(id);
            if (book == null)
            {
                return TypedResults.NotFound();
            }
            bookRepository.DeleteBook(book);
            return TypedResults.NoContent();
        }
        
        [ProducesResponseType(typeof(BookResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> UpdateBook(IBookRepository bookRepository, IAuthorRepository authorRepository, int id, [FromBody] BookPut book)
        {
            var existingBook = await bookRepository.GetBookById(id);
            if (existingBook == null)
            {
                return TypedResults.NotFound();
            }
            
            existingBook.Title = book.Title;
            Console.WriteLine(book.AuthorId);
            existingBook.AuthorId = book.AuthorId;
            var newBook = await bookRepository.UpdateBook(existingBook);
            
            newBook.Author.Books = new List<Book>();
            return TypedResults.Ok(new BookResponse(newBook));
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> CreateBook(IBookRepository bookRepository,
            IAuthorRepository authorRepository, [FromBody] BookPost book)
        {
            try
            {
                Validator.ValidateObject(book, new ValidationContext(book), true);
            }
            catch (ValidationException e)
            {
                return TypedResults.BadRequest(e.Message);
            }
            
            var author = await authorRepository.GetAuthorById(book.AuthorId);
            if (author == null)
            {
                return TypedResults.NotFound();
            }

            var newBook = new Book
            {
                Title = book.Title,
                AuthorId = book.AuthorId
            };
            var createdBook = await bookRepository.AddBook(newBook);
            createdBook.Author.Books = new List<Book>();
            return TypedResults.Created("/books/" + createdBook.Id);
        }
    }
}
