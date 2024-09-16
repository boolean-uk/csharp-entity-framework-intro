using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.Extensions.Hosting;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public record UpdatePostAuthorRequestDTO(string firstName, string lastName, string email);
    public record BookPostPayload(string title);

    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            app.MapGet("/books", GetBooks);
            app.MapGet("/books{id}", GetBook);
            app.MapPut("/books/{postId}/author/", UpdateAuthor);
            app.MapDelete("/books{id}", DeleteBook);
            app.MapPost("/books{authorID}", CreateBook);
        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            return TypedResults.Ok(BookResponseDTO.FromRepository(books));
        }

        private static async Task<IResult> GetBook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetBook(id);
            if (book == null)
                return Results.NotFound("Id out of scope");

            return TypedResults.Ok(BookResponseDTO.FromARepository(book));
        }

        private static async Task<IResult> UpdateAuthor(int id, UpdatePostAuthorRequestDTO payload, IBookRepository bookRepository, IAuthorRepository authorRepository)
        {
            Book? book = await bookRepository.GetBook(id);
            if (book == null)
                return Results.NotFound("Id out of scope");

            book.Author.FirstName = payload.firstName;
            book.Author.LastName = payload.lastName;
            book.Author.Email = payload.email;
            bookRepository.SaveChanges();

            return TypedResults.Ok(new BookResponseDTO(book));
        }

        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetBook(id);
            if (book == null)
                return Results.NotFound("Id out of scope");

            var allBooks = await bookRepository.DeleteBook(id);
            return TypedResults.Ok(BookResponseDTO.FromRepository(allBooks));
        }

        private static async Task<IResult> CreateBook(IBookRepository bookRepository, IAuthorRepository authorRepository, BookPostPayload createdBook, int authorID)
        {
            var book = await bookRepository.CreateBook(createdBook.title);
            if (book == null)
                return Results.BadRequest(createdBook.title);

            Author? author = await authorRepository.GetAuthor(authorID);
            if (author == null)
                return Results.NotFound("Author Id out of scope");

            book.Author = author;
            book.AuthorId = authorID;
            return TypedResults.Ok(BookResponseDTO.FromARepository(book));
        }
    }
}
