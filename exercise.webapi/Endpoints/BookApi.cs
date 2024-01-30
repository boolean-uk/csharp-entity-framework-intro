using exercise.webapi.DTOs;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.Extensions.Hosting;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public record UpdateBookAuthorRequestDTO(int authorId);

        public static void ConfigureBooksApi(this WebApplication app)
        {
            app.MapGet("/books", GetBooks);
            app.MapGet("/books{id}", GetBook);
            app.MapPut("/books{id}/author", UpdateBookAuthor);
            app.MapDelete("/books{id}", DeleteBook);
            app.MapPost("/books", CreateBook);
        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            return TypedResults.Ok(BookResponseDTO.FromRepository(books));
        }

        private static async Task<IResult> GetBook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetBook(id);
            if(book == null)
            {
                return TypedResults.NotFound();
            }
            return TypedResults.Ok(new BookResponseDTO(book));
        }

        private static async Task<IResult> UpdateBookAuthor(int bookId, UpdateBookAuthorRequestDTO payload, IBookRepository booksRepository, IAuthorRepository authorsRepository)
        {
            // get the book
            Book? book = await booksRepository.GetBook(bookId);
            if (book == null)
            {
                return TypedResults.NotFound();
            }
            Author? author = await authorsRepository.GetAuthor(payload.authorId);
            if (author == null)
            {
                return TypedResults.NotFound();
            }
            book.AuthorId = author.Id;
            book.Author = author;

            booksRepository.SaveChanges();

            return TypedResults.Ok(new BookResponseDTO(book));
        }

        private static async Task<IResult> DeleteBook(int bookId, IBookRepository booksrepository)
        {
            Book? book = await booksrepository.DeleteBook(bookId);
            if (book == null)
            {
                return TypedResults.NotFound();
            }
            
            return TypedResults.Ok(new BookResponseDTO(book));
        }
        private static async Task<IResult> CreateBook(IAuthorRepository authorsRepository, string title, int authorId, int bookId, IBookRepository bookrepository)
        {
            Author? author = await authorsRepository.GetAuthor(authorId);
            if (author == null)
            {
                return TypedResults.NotFound();
            }
            Book? book = await bookrepository.CreateBook(bookId, authorId, author, title);
            if(book == null)
            {
                return TypedResults.BadRequest();
            }

            return TypedResults.Ok(new BookResponseDTO(book));
        }

    }
}
