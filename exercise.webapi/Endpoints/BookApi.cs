using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            app.MapGet("/books", GetBooks);
            app.MapGet("/books/{id}", GetBook);
            app.MapPost("/books", AddBook);
            app.MapPut("/books/{author.id}", UpdateBook);
            app.MapGet("/authors", GetAuthors);
            app.MapGet("/authors/{id}", GetAuthorById);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            List<BookDTO> bookList = new List<BookDTO>();

            foreach (var book in books)
            {
                Author auth = await bookRepository.GetAuthor(book.AuthorId);

                BookDTO book1 = new BookDTO
                {
                    Id = book.Id,
                    Title = book.Title,
                    author = new AuthorDTO
                    {
                        Id = auth.Id,
                        FirstName = auth.FirstName,
                        LastName = auth.LastName,
                        Email = auth.Email
                    }
                };
                bookList.Add(book1);

            }

            return TypedResults.Ok(bookList);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAuthors(IBookRepository bookRepository)
        {
            var authors = await bookRepository.GetAllAuthors();
            List<AuthorDTO> authorList = new List<AuthorDTO>();

            foreach (var author in authors)
            {
                IEnumerable<Book> books = await bookRepository.GetBooksByAuthorId(author.Id);

                // Convert book entities to DTOs
                List<BookDTO> bookDTOs = books.Select(b => new BookDTO
                {
                    Id = b.Id,
                    Title = b.Title
                }).ToList();

                // Create an AuthorDTO with books
                AuthorDTO authorDTO = new AuthorDTO
                {
                    Id = author.Id,
                    FirstName = author.FirstName,
                    LastName = author.LastName,
                    Email = author.Email,
                };
                authorList.Add(authorDTO);
            }

            return TypedResults.Ok(authorList);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetAuthorById(IBookRepository bookRepository, int authorId)
        {
            if (authorId <= 0)
            {
                return TypedResults.BadRequest("Invalid author ID.");
            }

            var author = await bookRepository.GetAuthor(authorId);

            if (author == null)
            {
                return TypedResults.NotFound($"Author with ID {authorId} not found.");
            }

            IEnumerable<Book> books = await bookRepository.GetBooksByAuthorId(author.Id);


            List<BookDTO> bookDTOs = books.Select(b => new BookDTO
            {
                Id = b.Id,
                Title = b.Title
            }).ToList();

            AuthorDTO authorDTO = new AuthorDTO
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                Email = author.Email,
            };

            return TypedResults.Ok(authorDTO);
        }



        [ProducesResponseType(StatusCodes.Status200OK)]

        public static async Task<IResult> GetBook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetBook(id);
            if (book == null)
            {
                return Results.NotFound();
            }

            Author auth = await bookRepository.GetAuthor(book.AuthorId);

            BookDTO book1 = new BookDTO
            {
                Id = book.Id,
                Title = book.Title,
                author = new AuthorDTO
                {
                    Id = auth.Id,
                    FirstName = auth.FirstName,
                    LastName = auth.LastName,
                    Email = auth.Email
                }
            };

            return TypedResults.Ok(book1);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateBook(IBookRepository bookRepository, int id, AuthorDTONoId auth)
        {
            var book = await bookRepository.GetBook(id);

            BookDTONoAuthorID book1 = new BookDTONoAuthorID
            {
                Id = book.Id,
                Title = book.Title,
                author = new AuthorDTONoId
                {
                    FirstName = auth.FirstName,
                    LastName = auth.LastName,
                    Email = auth.Email
                }
            };

            book.Author.FirstName = auth.FirstName;
            book.Author.LastName = auth.LastName;
            book.Author.Email = auth.Email;

            await bookRepository.UpdateBook(book);

            return TypedResults.Created($"/books/{book1.Id}", book1);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> AddBook(IBookRepository bookRepository, string title, int author_id)
        {
            Author auth = await bookRepository.GetAuthor(author_id);

            Book book = new Book
            {
                Title = title,
                Author = auth
            };

            if (book.Author.Id == 0 || auth == null)
            {
                return TypedResults.BadRequest("Author ID is invalid");
            }

            if (string.IsNullOrWhiteSpace(title))
            {
                return TypedResults.BadRequest("Title cannot be empty.");
            }


            await bookRepository.AddBook(book);

            AuthorDTO authDTO = new AuthorDTO {
                Id = book.AuthorId,
                FirstName = book.Author.FirstName,
                LastName = book.Author.LastName,
                Email = book.Author.Email
            };

            BookDTO bookDTO = new BookDTO
            {
                Id = book.Id,
                Title = title,
                author = authDTO
            };

            return TypedResults.Created($"/books/{book.Id}", bookDTO);

        }
    }
}
