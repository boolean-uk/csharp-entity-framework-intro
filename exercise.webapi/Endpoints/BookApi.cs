using exercise.webapi.DTOs;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            var books = app.MapGroup("books");
            books.MapGet("/", GetBooks);
            books.MapGet("/{id}", GetABook);
        }


        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            List<BookDTO> result = [];
            foreach (var book in books)
            {
                var bookdto = MapToBookDTO(book);
                result.Add(bookdto);
            }
            return TypedResults.Ok(result);
        }
        private static async Task<IResult> GetABook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetBook(id);
            if (book == null) return TypedResults.NotFound("Book was not found");
            var bookdto = MapToBookDTO(book);
            return TypedResults.Ok(bookdto);
        }

        private static BookDTO MapToBookDTO(Book book)
        {
            return new BookDTO
            {
                Id = book.Id,
                Title = book.Title,
                AuthorId = book.AuthorId,
                Author = $"{book.Author.FirstName} {book.Author.LastName}"
            };
        }

        private static AuthorDTO MapToAuthorDTO(Author author)
        {
            return new AuthorDTO
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                Email = author.Email
            };
        }
    }
}
