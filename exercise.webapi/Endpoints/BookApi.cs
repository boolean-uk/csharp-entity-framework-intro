using exercise.webapi.Models;
using exercise.webapi.Models.DTO;
using exercise.webapi.Repository;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            var books = app.MapGroup("/book");

            books.MapGet("/", GetBooks);
            books.MapGet("/{id}", GetBook);
            books.MapPut("/{id}", UpdateBook);
            books.MapDelete("/", DeleteBook);
            books.MapPost("/{id}", AddBook);
        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            var result = new List<BookDTO>();
            foreach(var book in books)
            {
                result.Add(book.ToDTO());
            }
            return TypedResults.Ok(result);
        }

        private static async Task<IResult> GetBook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetBook(id);
            if (book == null)
            {
                return TypedResults.NotFound($"Book with id {id} was not found");
            }
            return TypedResults.Ok(book.ToDTO());
        }

        private static async Task<IResult> UpdateBook(IBookRepository bookRepository, int bookId, int authorId)
        {
            var book = await bookRepository.UpdateBook(bookId, authorId);
            if (book == null)
            {
                return TypedResults.NotFound($"Book or Author was not found");
            }
            return TypedResults.Created("/book/{id}", book.ToDTO());
        }

        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int bookId)
        {
            var book = await bookRepository.DeleteBook(bookId);
            if (book == null)
            {
                return TypedResults.NotFound($"Book with id {bookId} was not found");
            }
            return TypedResults.Ok(book.ToDTO());
        }

        private static async Task<IResult> AddBook(IBookRepository bookRepository, BookPost book)
        {
            if (book == null)
            {
                return TypedResults.BadRequest("Book is not valid");
            }

            var newBook = await bookRepository.AddBook(book);
            if (newBook == null)
            {
                return TypedResults.NotFound($"Author with author id {book.AuthorId} was not found");
            }
            return TypedResults.Created("/book/{id}", newBook.ToDTO());
        }
    }
}
