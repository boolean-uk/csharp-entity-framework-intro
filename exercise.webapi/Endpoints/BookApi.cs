using exercise.webapi.Models;
using exercise.webapi.Repository;
using exercise.webapi.DTOs;
using static System.Reflection.Metadata.BlobBuilder;
using Microsoft.Extensions.Hosting;
using static exercise.webapi.Repository.IAuthorRepository;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public record UpdateBookAuthorRequestDTO(int authorId);
        /*
        public record CreateBookRequestDTO
        {
            public int? AuthorId { get; init; }
            public Book? Book { get; init; }
        }*/

        public static void ConfigureBooksApi(this WebApplication app)
        {
            app.MapGet("/books", GetBooks);
            app.MapGet("/books/{Id}", GetABook);
            app.MapPut("/books/{bookId}/author/", UpdateBookAuthor);
            app.MapDelete("books/{Id}", DeleteBook);
            app.MapPost("/books/{newBook.Id}", CreateBook);
        }

        /*
        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            return TypedResults.Ok(BookResponseDTO.FromRepository(books));
        }


       
        private static async Task<IResult> GetABook(int bookId, IBookRepository bookRepository)
        {
            var book = await bookRepository.GetBook(bookId);
            if (book == null)
            {
                return TypedResults.NotFound();
            }

            return TypedResults.Ok(new BookResponseDTO(book));
        }
        */
        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            return TypedResults.Ok(BookResponseDTO.FromRepository(books));
        }


        private static async Task<IResult> GetABook(int bookId, bool includeAuthors, IBookRepository bookRepository)
        {
            var book = await bookRepository.GetBook(bookId);
            if (book == null)
            {
                return TypedResults.NotFound();
            }

            if (includeAuthors)
            {
                return TypedResults.Ok(new BookResponseDTO(book));
            }
            else
            {
                return TypedResults.Ok(new BookResponseDTO(book) { Author = null });
            }
        }

        public static async Task<IResult> UpdateBookAuthor(int bookId, UpdateBookAuthorRequestDTO payload, IBookRepository booksRepository, IAuthorRepository authorsRepository)
        {
            // get the post
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
            //var bookAuthor = new BookAuthor { AuthorId = author.Id };
            //book.BookAuthors.Add(bookAuthor);

            booksRepository.SaveChanges();

            return TypedResults.Ok(new BookResponseDTO(book));
        }

        private static async Task<IResult> DeleteBook(int bookId, IBookRepository bookRepository)
        {
            Book? book = await bookRepository.DeleteBook(bookId);
            if (book == null)
            {
                return TypedResults.NotFound();
            }
            bookRepository.SaveChanges();
            return TypedResults.Ok(new BookResponseDTO(book));
        }


        private static async Task<IResult> CreateBook(int authorId, int bookid, string bookTitle, IBookRepository bookRepository, IAuthorRepository authorRepository)
        {
         

            // Get the author
            Author? author = await authorRepository.GetAuthor(authorId);
            if (author == null)
            {
                return TypedResults.NotFound();
            }

            // Validate the book object
            Book? book = await bookRepository.GetBook(bookid);
            if (book != null)
            {
                return TypedResults.BadRequest();
            }

            if (string.IsNullOrEmpty(bookTitle))
            {
                return TypedResults.BadRequest(new { Title = "Title is required." });
            }

            // Create a new book
            Book newBook = new Book
            {
                Id = bookid,
                Title = bookTitle,
                AuthorId = authorId,
                Author = author
            };

            // Add the new book to the repository
            await bookRepository.AddBook(newBook);

            // Return the new book
            return TypedResults.Created($"/books/{newBook.Id}", new BookResponseDTO(newBook));
        }

    }
}
