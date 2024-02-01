using exercise.webapi.Models;
using exercise.webapi.Models.DTO;
using exercise.webapi.Repository;
using System.Collections.Generic;
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
            group.MapPut("/{bookId}", UpdateBook);
            group.MapDelete("/{id}", DeleteBook);
            group.MapPost("/", CreateBook);
        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            IEnumerable<Book> books = await bookRepository.GetAllBooks();

            IEnumerable <OutputBook> outputBooks = Services.DtoManager.Convert(books);

            return TypedResults.Ok(outputBooks);
        }

        private static async Task<IResult> GetBook(IBookRepository bookRepository, int id)
        {
            Book? book = await bookRepository.GetBook(id);

            if (book == null)
                return Results.NotFound();

            OutputBook outputBook = Services.DtoManager.Convert(book);
            return TypedResults.Ok(outputBook);
        }

        private static async Task<IResult> UpdateBook(IBookRepository bookRepository, int bookId, int authorId)
        {
            Book? book = await bookRepository.UpdateBook(bookId, authorId);

            if (book == null)
                return Results.NotFound();

            OutputBook outputBook = Services.DtoManager.Convert(book);
            return TypedResults.Ok(outputBook);
        }

        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            Book? book = await bookRepository.DeleteBook(id);

            if (book == null)
                return Results.NotFound();

            OutputBook outputBook = Services.DtoManager.Convert(book);
            return TypedResults.Ok(outputBook);
        }

        private static async Task<IResult> CreateBook(IBookRepository bookRepository, InputBook book)
        {
            Book newBook = new Book()
            {
                Title = book.Title,
                AuthorId = book.AuthorId
            };
            
            Book? test = await bookRepository.CreateBook(newBook);

            if (test == null)
                return Results.BadRequest();

            OutputBook outputBook = Services.DtoManager.Convert(test);
            return TypedResults.Ok(outputBook);
        }
    }
}
