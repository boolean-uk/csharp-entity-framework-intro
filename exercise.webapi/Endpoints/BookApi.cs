using exercise.webapi.Models;
using exercise.webapi.Models.ModelsBookAPI;
using exercise.webapi.Repository.GenericRepository;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        private static async Task<IResult> GetBooks(IRepository<Book> bookRepository, IRepository<Author> authorRepository)
        {
            var books = await bookRepository.Get();
            var bookDtos = books.Select(book => new BookDto
            {
                Id = book.Id,
                Title = book.Title,
                Authors = book.BookAuthorPairs.Select(pair => new AuthorDto
                {
                    Id = pair.Author.Id,
                    Email = pair.Author.Email,
                    FirstName = pair.Author.FirstName,
                    LastName = pair.Author.LastName
                }).ToList()
            }).ToList();

            return TypedResults.Ok(bookDtos);
        }

        private static async Task<IResult> GetBookById(IRepository<Book> bookRepository, IRepository<Author> authorRepository, int id)
        {
            var book = await bookRepository.GetById(id);
            if (book == null)
            {
                return TypedResults.NotFound();
            }

            var bookDto = new BookDto
            {
                Id = book.Id,
                Title = book.Title,
                Authors = book.BookAuthorPairs.Select(pair => new AuthorDto
                {
                    Id = pair.Author.Id,
                    Email = pair.Author.Email,
                    FirstName = pair.Author.FirstName,
                    LastName = pair.Author.LastName
                }).ToList()
            };

            return TypedResults.Ok(bookDto);
        }

        private static async Task<IResult> UpdateBook
            (
                IRepository<Book> bookRepository,
                IRepository<Author> authorRepository,
                IRepository<BookAuthor> bookAuthorRepository,
                BookInput bookInput, 
                int id
            )
        {
            var book = await bookRepository.GetById(id);
            if (book == null)
            {
                return TypedResults.NotFound();
            }

            var allBookAuthors = await bookAuthorRepository.Get();
            var relevantBookAuthors = allBookAuthors.Where(ba => ba.BookId == id);
            foreach (var bookAuthor in relevantBookAuthors)
            {
                
                await bookAuthorRepository.Delete(bookAuthor);
            }

            book.Title = bookInput.Title;

            foreach (var authorId in bookInput.AuthorIds)
            {
                var author = await authorRepository.GetById(authorId);
                if (author == null)
                {
                    return Results.BadRequest($"Author with ID {authorId} not found.");
                }

                var bookAuthor = new BookAuthor
                {
                    BookId = id,
                    AuthorId = authorId
                };
                await bookAuthorRepository.Insert(bookAuthor);
            }

            book = await bookRepository.Update(book);

            var updatedBookDto = new BookDto
            {
                Id = book.Id,
                Title = book.Title,
                Authors = ConstructAuthorDtosFromBook(book)
            };

            return TypedResults.Ok(updatedBookDto);
        }



        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> DeleteBook(IRepository<Book> bookRepository, int id)
        {
            var book = await bookRepository.GetById(id);
            if (book == null)
            {
                return TypedResults.NotFound();
            }

            await bookRepository.Delete(id);
            return TypedResults.Ok($"Book with ID {id} deleted successfully.");
        }

        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> CreateBook(
                             IRepository<Book> bookRepository,
                             IRepository<Author> authorRepository,
                             IRepository<BookAuthor> bookAuthorRepository,
                             BookInput bookInput)
        {
            var newBook = new Book
            {
                Title = bookInput.Title,
                BookAuthorPairs = new List<BookAuthor>()
            };

            var insertedBook = await bookRepository.Insert(newBook);

            foreach (var authorId in bookInput.AuthorIds)
            {
                var author = await authorRepository.GetById(authorId);
                if (author == null)
                {
                    return Results.BadRequest($"Author with ID {authorId} not found.");
                }

                var bookAuthor = new BookAuthor
                {
                    AuthorId = authorId,
                    BookId = insertedBook.Id
                };

                await bookAuthorRepository.Insert(bookAuthor);
            }

            var bookDto = new BookDto
            {
                Id = insertedBook.Id,
                Title = insertedBook.Title,
                Authors = ConstructAuthorDtosFromBook(insertedBook)
            };

            return Results.Created($"/books/{insertedBook.Id}", bookDto);
        }


        private static List<AuthorDto> ConstructAuthorDtosFromBook(Book book)
        {
            return book.BookAuthorPairs.Select(pair => new AuthorDto
            {
                Id = pair.Author.Id,
                Email = pair.Author.Email,
                FirstName = pair.Author.FirstName,
                LastName = pair.Author.LastName
            }).ToList();
        }
    }
}
