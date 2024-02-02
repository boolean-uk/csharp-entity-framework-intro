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
            var books = app.MapGroup("books");
            books.MapGet("/", GetBooks);
            books.MapGet("/{id}", GetBookById);
            books.MapPost("/", CreateBook);
            books.MapPut("/{id}", UpdateBook);
            books.MapDelete("/{id}", DeleteBook);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var bookClasses = await bookRepository.GetAllBooks();

            List<BookResponseDTO> bookDTOs = new List<BookResponseDTO>();

            foreach (var bookClass in bookClasses)
            {
                var bookDTO = new BookResponseDTO
                {
                    Id = bookClass.Id,
                    Title = bookClass.Title,
                    PublisherId = bookClass.PublisherId,
                    Publisher = new PublisherDTO
                    {
                        Name = bookClass.Publisher.Name
                    },
                    Authors = bookClass.BookAuthors.Select(ba => new AuthorDTO
                    {
                        FirstName = ba.Author.FirstName,
                        LastName = ba.Author.LastName,
                        Email = ba.Author.Email
                    }).ToList()
                };
                bookDTOs.Add(bookDTO);
            }

            return TypedResults.Ok(bookDTOs);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBookById(IBookRepository bookRepository, int id)
        {
            var bookClass = await bookRepository.GetBookById(id);

            if (bookClass == null)
            {
                return TypedResults.NotFound();
            }

            var bookDTO = new BookResponseDTO
            {
                Id = bookClass.Id,
                Title = bookClass.Title,
                PublisherId = bookClass.PublisherId,
                Publisher = new PublisherDTO
                {
                    Name = bookClass.Publisher.Name
                },
                Authors = bookClass.BookAuthors.Select(ba => new AuthorDTO
                {
                    FirstName = ba.Author.FirstName,
                    LastName = ba.Author.LastName,
                    Email = ba.Author.Email
                }).ToList()
            };

            return TypedResults.Ok(bookDTO);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> UpdateBook(IBookRepository bookRepository, int bookId, int newAuthorId)
        {
            var bookClass = await bookRepository.UpdateBook(bookId, newAuthorId);

            if (bookClass == null)
            {
                return TypedResults.NotFound();
            }

            var bookDTO = new BookResponseDTO
            {
                Id = bookClass.Id,
                Title = bookClass.Title,
                PublisherId = bookClass.PublisherId,
                Publisher = new PublisherDTO
                {
                    Name = bookClass.Publisher.Name
                },
                Authors = bookClass.BookAuthors.Select(ba => new AuthorDTO
                {
                    FirstName = ba.Author.FirstName,
                    LastName = ba.Author.LastName,
                    Email = ba.Author.Email
                }).ToList()
            };

            return TypedResults.Ok(bookDTO);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int bookId)
        {
            var foundBookClass = await bookRepository.DeleteBook(bookId);

            if (foundBookClass == null)
            {
                return TypedResults.NotFound("The book you want to delete does not exist.");
            }

            var deletedBookDTO = new BookResponseDTO
            {
                Id = foundBookClass.Id,
                Title = foundBookClass.Title,
                PublisherId = foundBookClass.PublisherId,
                Publisher = new PublisherDTO
                {
                    Name = foundBookClass.Publisher.Name
                },
                Authors = foundBookClass.BookAuthors.Select(ba => new AuthorDTO
                {
                    FirstName = ba.Author.FirstName,
                    LastName = ba.Author.LastName,
                    Email = ba.Author.Email
                }).ToList()
            };

            return TypedResults.Ok(deletedBookDTO);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> CreateBook(IBookRepository bookRepository, BookPost model)
        {
            var book = await bookRepository.CreateBook(model);

            if (book == null)
            {
                return TypedResults.NotFound("Author or Publisher not found, or book title is not valid.");
            }

            var bookDTO = new BookResponseDTO
            {
                Id = book.Id,
                Title = book.Title,
                PublisherId = book.PublisherId,
                Publisher = new PublisherDTO
                {
                    Name = book.Publisher.Name
                },
                Authors = book.BookAuthors.Select(ba => new AuthorDTO
                {
                    FirstName = ba.Author.FirstName,
                    LastName = ba.Author.LastName,
                    Email = ba.Author.Email
                }).ToList()
            };

            return TypedResults.Ok(bookDTO);
        }
    }
}
