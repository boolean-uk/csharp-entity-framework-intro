using exercise.webapi.Models;
using exercise.webapi.Repository;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            var groupMembers = app.MapGroup("books");
            groupMembers.MapGet("/", GetBooks);
            groupMembers.MapGet("/{id}", GetBookById);
        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            List<BookDto> bookDtos = new List<BookDto>();
            var books = await bookRepository.GetAllBooks();
            foreach (var book in books)
            {
                var Author = book.Author;

                var authorDto = new AuthorDto()
                {
                    Id = Author.Id,
                    Email = Author.Email,
                    FirstName = Author.FirstName,
                    LastName = Author.LastName
                };
                var bookDto = new BookDto()
                {
                    Id = book.Id,
                    Title = book.Title,
                    AuthorId = book.AuthorId,
                    Author = authorDto
                };

                bookDtos.Add(bookDto);

            }
            return TypedResults.Ok(books);
        }

        private static async Task<IResult> GetBookById(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetBook(id);
            var Author = book.Author;

            var authorDto = new AuthorDto()
            {
                Id = Author.Id,
                Email = Author.Email,
                FirstName = Author.FirstName,
                LastName = Author.LastName
            };
            var bookDto = new BookDto()
            {
                Id = book.Id,
                Title = book.Title,
                AuthorId = book.AuthorId,
                Author = authorDto
            };
            return TypedResults.Ok(bookDto);
        }
    }
}
