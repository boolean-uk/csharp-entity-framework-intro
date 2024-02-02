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
        private static async Task<IResult> UpdateBook(IBookRepository bookRepository, int bookId, BookPut model)
        {
            var updatedBook = await bookRepository.UpdateBook(bookId, model);

            if (updatedBook == null)
            {
                return TypedResults.NotFound();
            }

            var bookDTO = new BookResponseDTO
            {
                Id = updatedBook.Id,
                Title = updatedBook.Title,
                PublisherId = updatedBook.PublisherId,
                Publisher = new PublisherDTO
                {
                    Name = updatedBook.Publisher.Name
                },
                Authors = updatedBook.BookAuthors.Select(ba => new AuthorDTO
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
            // Validate author ids
            var areAuthorsValid = await bookRepository.AreAuthorsValid(model.AuthorIds);

            if (!areAuthorsValid)
            {
                return TypedResults.NotFound("One or more authors not found.");
            }

            // Create book using the repository
            var book = await bookRepository.CreateBook(model);

            // Check if the book object is not valid
            if (book == null)
            {
                return TypedResults.BadRequest("Invalid book data.");
            }

            // Create the BookResponseDTO
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

            // Return the Ok result with the bookDTO
            return TypedResults.Ok(bookDTO);
        }
    }
}
