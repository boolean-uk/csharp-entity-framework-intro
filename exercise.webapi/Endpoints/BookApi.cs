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
                    AuthorId = bookClass.AuthorId,
                    Author = new AuthorDTO
                    {
                        Id = bookClass.Author.Id,
                        FirstName = bookClass.Author.FirstName,
                        LastName = bookClass.Author.LastName,
                        Email = bookClass.Author.Email
                    }
                };
                bookDTOs.Add(bookDTO);
            }

            return TypedResults.Ok(bookDTOs);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBookById(IBookRepository bookRepository, int id)
        {
            var bookClass = await bookRepository.GetBookById(id);

            var bookDTO = new BookResponseDTO
            {
                Id = bookClass.Id,
                Title = bookClass.Title,
                AuthorId = bookClass.AuthorId,
                Author = new AuthorDTO
                {
                    Id = bookClass.Author.Id,
                    FirstName = bookClass.Author.FirstName,
                    LastName = bookClass.Author.LastName,
                    Email = bookClass.Author.Email
                }
            };

            return TypedResults.Ok(bookDTO);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> UpdateBook(IBookRepository bookRepository, int bookId, int newAuthorId)
        {
            var bookClass = await bookRepository.UpdateBook(bookId, newAuthorId);

            if (bookClass == null)
            {
                // Handle the case where the book or author is not found, e.g., return a 404 Not Found response.
                return TypedResults.NotFound();
            }

            var bookDTO = new BookResponseDTO
            {
                Id = bookClass.Id,
                Title = bookClass.Title,
                AuthorId = bookClass.AuthorId,
                Author = new AuthorDTO
                {
                    Id = bookClass.Author.Id,
                    FirstName = bookClass.Author.FirstName,
                    LastName = bookClass.Author.LastName,
                    Email = bookClass.Author.Email
                }
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
                AuthorId = foundBookClass.AuthorId,
                Author = new AuthorDTO
                {
                    Id = foundBookClass.Author.Id,
                    FirstName = foundBookClass.Author.FirstName,
                    LastName = foundBookClass.Author.LastName,
                    Email = foundBookClass.Author.Email
                }
            };

            return TypedResults.Ok(deletedBookDTO);
        }



        /*
         * implement the CREATE book - it should return NotFound when author id is not valid and BadRequest when book object not valid
         */
        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> CreateBook(IBookRepository bookRepository, BookPost model)
        {
            var book = await bookRepository.CreateBook(model);

            if (book.Author == null)
            {
                return TypedResults.NotFound("Author not found");
            }
            else if (string.IsNullOrWhiteSpace(book.Title) || book.Title == "string") //"string" as in no changes made to the default string of "string" in swagger.)
            {
                return TypedResults.BadRequest("Book title is not valid");
            }
            else
            {
                var bookDTO = new BookResponseDTO
                {
                    Id = book.Id,  // Assuming Id is generated by the database upon creation
                    Title = book.Title,
                    AuthorId = book.AuthorId,
                    Author = new AuthorDTO
                    {
                        Id = book.Author.Id,
                        FirstName = book.Author.FirstName,
                        LastName = book.Author.LastName,
                        Email = book.Author.Email
                    }
                };
                return TypedResults.Ok(bookDTO);
            }
        }
    }
}
