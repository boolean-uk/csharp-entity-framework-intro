using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.Extensions.Hosting;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public record UpdatePostAuthorRequestDTO(string firstName, string lastName, string email);

    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            app.MapGet("/books", GetBooks);
            app.MapGet("/books{id}", GetBook);
            app.MapPut("/books/{postId}/author/", UpdateAuthor);
            app.MapDelete("/books{id}", DeleteBook);
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
    }
}
