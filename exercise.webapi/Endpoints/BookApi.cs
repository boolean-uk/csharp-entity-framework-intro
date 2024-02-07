using exercise.webapi.Models;
using exercise.webapi.Models.ModelsBookAPI;
using exercise.webapi.Repository.GenericRepository;
using Microsoft.AspNetCore.Mvc;
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
            groupMembers.MapPut("/{id}", UpdateBook);
            groupMembers.MapDelete("/{id}", DeleteBook);
            groupMembers.MapPost("/", CreateBook);
        }

        private static async Task<IResult> GetBooks(IRepository<Book> bookRepository)
        {
            List<BookDto> bookDtos = new List<BookDto>();
            var books = await bookRepository.Get();
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
                    Author = authorDto
                };

                bookDtos.Add(bookDto);

            }
            return TypedResults.Ok(bookDtos);
        }

        private static async Task<IResult> GetBookById(IRepository<Book> bookRepository, int id)
        {
            var book = await bookRepository.GetById(id);
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
                Author = authorDto
            };
            return TypedResults.Ok(bookDto);
        }

        private static async Task<IResult> UpdateBook(IRepository<Book> bookRepository, int id, AuthorInput authorPut)
        {
            var book = await bookRepository.GetById(id);
            book.Author.FirstName = authorPut.FirstName;
            book.Author.LastName = authorPut.LastName;
            book.Author.Email = authorPut.Email;

            await bookRepository.Update(book);

            var authorDto = new AuthorDto()
            {
                Id = book.Author.Id,
                Email = book.Author.Email,
                FirstName = book.Author.FirstName,
                LastName = book.Author.LastName
            };
            var bookDto = new BookDto()
            {
                Id = book.Id,
                Title = book.Title,
                Author = authorDto
            };
            return TypedResults.Ok(bookDto);
        }

        private static async Task<IResult> DeleteBook(IRepository<Book> bookRepository, int id)
        {
            var book = await bookRepository.GetById(id);
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
                Author = authorDto
            };

            await bookRepository.Delete(id);
            return TypedResults.Ok(bookDto);
        }

        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> CreateBook(IRepository<Book> bookRepository, IRepository<Author> authorRepository, BookInput bookInput)
        {
            int authorId = bookInput.AuthorId;
            Author author = await authorRepository.GetById(authorId);

            if (author == null)
            {
                return Results.NotFound(new { Message = $"Author with ID {authorId} not found." });
            }

            IEnumerable<Book> books = await bookRepository.Get();

            if (books.Any(b => b.Title.Equals(bookInput.Title, StringComparison.OrdinalIgnoreCase)))
            {
                return Results.BadRequest(new { Message = $"A book with the title '{bookInput.Title}' already exists." });
            }

            var book = new Book();
            book.Id = books.Any() ? books.Max(b => b.Id) + 1 : 1;
            book.Title = bookInput.Title;
            book.Author = author;
           
            await bookRepository.Insert(book);

            var authorDto = new AuthorDto()
            {
                Id = book.Author.Id,
                Email = book.Author.Email,
                FirstName = book.Author.FirstName,
                LastName = book.Author.LastName
            };
            var bookDto = new BookDto()
            {
                Id = book.Id,
                Title = book.Title,
                Author = authorDto
            };
            return Results.Created($"/books/{book.Id}", bookDto);
        }
    }
}
