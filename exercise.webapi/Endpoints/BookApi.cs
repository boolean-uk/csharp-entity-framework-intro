using exercise.webapi.Models.DTOs;
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

            app.MapGet("/", GetBooks);
            app.MapGet("/{id}", GetBookById);
            app.MapPost("/", CreateBook);
            app.MapPut("/", UpdateBooksAuthor);
            app.MapDelete("/", DeleteBook);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            return TypedResults.Ok(books);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetBookById(IBookRepository bookRepository, int id) 
        {
            var book = await bookRepository.GetBookById(id);
            if (book == null)
            {
                return TypedResults.NotFound("Book with provided id doesn't exists");
            }
            return TypedResults.Ok(book);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> CreateBook(IBookRepository bookRepository, CreateBookDto bookDto)
        {
            var bookToAdd = await bookRepository.CreateBook(bookDto);
            return TypedResults.Ok(bookToAdd);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> UpdateBooksAuthor(IBookRepository bookRepository, int id, int newAuthor) 
        {
            
            if (newAuthor < 0 || newAuthor > bookRepository.GetAmountOfAuthors()) 
            {
                return TypedResults.BadRequest("Author with provided id doesn't exists");
            }
            else if (bookRepository.GetBookById(id) == null)
            {
                return TypedResults.NotFound("Book with provided id doesn't exists");
            }

            var book = await bookRepository.UpdateBooksAuthor(id, newAuthor);
            return TypedResults.Ok(book);
        }
        
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id) 
        {
            if (bookRepository.GetBookById(id) == null)
            {
                return TypedResults.NotFound("Book with provided id doesn't exists");
            }

            var book = await bookRepository.DeleteBook(id);
            return TypedResults.Ok(book);
        }
    }
}
