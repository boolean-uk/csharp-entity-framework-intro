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
            app.MapPut("/books/update/{id}", UpdateBook);
            app.MapDelete("/book/delete/{id}", DeleteBook);
            app.MapPost("/book/create", CreateBook);


            app.MapGet("/author", GetAuthors);
            app.MapGet("/author/{id}", GetAuthor);


        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            return TypedResults.Ok(books);
        }

        private static async Task<IResult> GetBook(IBookRepository bookRepository, int id)
        {
            var books = await bookRepository.GetBookById(id);
            return TypedResults.Ok(books);
        }

        private static async Task<IResult> UpdateBook(IBookRepository bookRepository, int id, int newAuthorId)
        {
            var books = await bookRepository.UpdateBookById(id, newAuthorId);
            return TypedResults.Ok(books);
        }

        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            var books = await bookRepository.DeleteBookById(id);
            return TypedResults.Ok(books);
        }

        private static async Task<IResult> CreateBook(IBookRepository bookRepository, BookDTO book)
        {
            var books = await bookRepository.CreateBook(book);
            return TypedResults.Ok(books);
        }




        private static async Task<IResult> GetAuthors(IBookRepository bookRepository)
        {
            var author = await bookRepository.GetAllAuthors();
            return TypedResults.Ok(author);
        }

        private static async Task<IResult> GetAuthor(IBookRepository bookRepository, int id)
        {
            var author = await bookRepository.GetAuthorById(id);
            return TypedResults.Ok(author);
        }

    }
}
