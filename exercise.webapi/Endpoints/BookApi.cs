using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            app.MapGet("/books", GetBooks);
            app.MapGet("/books/{id}", GetBook);
            app.MapPut("/books/update/{AuthorID}", UpdateBook);
            app.MapDelete("/books/Delete/{id}", DeleteBook);
            app.MapPost("/books/Create", CreateBook);
        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            return TypedResults.Ok(books);
        }

        private static async Task<IResult> GetBook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetBook(id);
            return TypedResults.Ok(book);
        }

        private static async Task<IResult> UpdateBook(IBookRepository bookRepository, int AuthorID, DTOBook book)
        {
            var updatedbook = await bookRepository.UpdateBook(book, AuthorID);
            return TypedResults.Ok(updatedbook);
        }

        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int bookid)
        {
            var deletedbook = await bookRepository.DeleteBook(bookid);
            return TypedResults.Ok(deletedbook);
        }
        private static async Task<IResult> CreateBook(IBookRepository bookRepository, DTOBook book)
        {
            var addedBook = await bookRepository.AddBook(book);
            if (addedBook != null)
            {
                return TypedResults.Ok(addedBook);
            }
            else
            {
                return TypedResults.NotFound("Could not find author");
            }
        }
    }
}
