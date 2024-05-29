using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public record UpdateBookAuthorRequestDTO(int authorId);
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            app.MapGet("/books", GetBooks);
            app.MapGet("/books/{bookId}", GetBook);
            app.MapPut("/books/{bookId}/author/", UpdateBookAuthor);
            app.MapDelete("/books/{bookId}", DeleteBookAuthor);

        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            // receiving the post lists
            var books = await bookRepository.GetBooksAsync();
            // Go to the DTO and calling the static method FromtRepository that receives the books
            // and converts them into the list of DTO's
            return TypedResults.Ok(BookResponseDTO.FromRepository(books));
        }

        private static async Task<IResult> GetBook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetBook(id);
            if (book == null)
            {
                return TypedResults.NotFound();
            }
            return TypedResults.Ok(new BookResponseDTO(book));
        }

        // you'll need the IBookRepo and IAuthorRepo to check if the book and the author exists otherwise you cant update
        public static async Task<IResult> UpdateBookAuthor(int bookId, UpdateBookAuthorRequestDTO payload, IBookRepository bookRepository, IAuthorsRepository authorsRepository)
        {
            // get the book
            Book? book = await bookRepository.GetBook(bookId);
            if (book == null)
            {
                return TypedResults.NotFound();
            }
            // get the author
            Author? author = await authorsRepository.GetAuthor(payload.authorId);
            if (author == null) { return TypedResults.NotFound(); }
            book.AuthorId = author.Id;
            book.Author = author;

            // save the book repo
            bookRepository.SaveChanges();

            return TypedResults.Ok(new BookResponseDTO(book));
        }

        public static async Task<IResult> DeleteBookAuthor(IBookRepository bookRepository, int bookId)
        {
            Book? book = await bookRepository.GetBook(bookId);
            if(book == null)
            {
                return TypedResults.NotFound();
            }
            return TypedResults.Ok(new BookResponseDTO(book));
        }
    }
}
