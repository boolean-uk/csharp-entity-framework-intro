using exercise.webapi.Models;
using exercise.webapi.Repository;
using exercise.webapi.Services;
using System.Runtime.InteropServices;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {

        public static void ConfigureBooksApi(this WebApplication app)
        {
            app.MapGet("/books", GetBooks);
            app.MapGet("/books/{id}", GetBook);
            app.MapPatch("/books/{id}", UpdateBook);
            app.MapDelete("/books/{id}", DeleteBook);
            app.MapPost("/books", CreateBook);
        }

        private static async Task<IResult> GetBooks(BookService bookService)
        {
            var books = await bookService.GetBooks();
            return TypedResults.Ok(books);
        }

        private static async Task<IResult> GetBook(BookService bookService, int id)
        {
            var book = await bookService.GetBook(id);

            return book != null ? TypedResults.Ok(book) : TypedResults.NotFound("Book not found");
        }

        private static async Task<IResult> UpdateBook(BookService bookService, int id, UpdateBookAuthorDTO updateDTO)
        {
            BookDTO book = null;
            try
            {
                book = await bookService.UpdateBook(id, updateDTO);
            }
            catch (Exception ex)
            {
                return TypedResults.NotFound(ex.Message);
            }
            return TypedResults.Ok(book);
        }

        private static async Task<IResult> DeleteBook(BookService bookService, int id)
        {
            BookDTO book = null;
            try
            {
                book = await bookService.DeleteBook(id);
            }
            catch (Exception ex)
            {
                return TypedResults.NotFound(ex.Message);
            }
            return TypedResults.Ok(book);
        }

        private static async Task<IResult> CreateBook(BookService bookService, CreateBookDTO createDTO)
        {
            BookDTO book = null;
            try
            {
                book = await bookService.CreateBook(createDTO);
            }
            catch (Exception ex)
            {
                return TypedResults.NotFound(ex.Message);
            }
            
            return TypedResults.Ok(book);
        }
        
    }
}
