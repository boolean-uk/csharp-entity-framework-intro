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
            app.MapGet("/{id}", GetBook);
            app.MapPost("/", AddBook);
            app.MapDelete("/{id}", DeleteBook);
            app.MapPut("/{id}", UpdateBook);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
                 var booksDTO = books.Select(b => new BookDTO
            {
                Id = b.Id,
                Title = b.Title,
                AuthorId = b.AuthorId,
                Author = new AuthorDTO
                {
                    Id = b.Author.Id,
                    FirstName = b.Author.FirstName,
                    LastName = b.Author.LastName,
                    Email = b.Author.Email
                }
            });
            return TypedResults.Ok(booksDTO);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetBook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.Get(id);
            if (book == null)
            {
                return TypedResults.NotFound();
            }
            var bookDTO = new BookDTO
            {
                Id = book.Id,
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
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> AddBook(IBookRepository bookRepository, IAuthorRepository authorRepository, BookPost model)
        {
            try
            {
                var result = await authorRepository.Get(model.AuthorId);
                Book book = new Book
                {
                    Title = model.Title,
                    AuthorId = model.AuthorId
                };
                await bookRepository.Add(book);

                BookDTO returning = new BookDTO
                {
                    Id = book.Id,
                    Title = model.Title,
                    AuthorId = model.AuthorId,
                    Author = new AuthorDTO
                    {
                        Id = result.Id,
                        FirstName = result.FirstName,
                        LastName = result.LastName,
                        Email = result.Email
                    }
                };
                return TypedResults.Ok(returning);
            }
            catch (Exception e)
            {
                return TypedResults.BadRequest(e);
            }
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            var deleting = await bookRepository.Delete(id);
            if (!deleting)
            {
                return TypedResults.NotFound("No book with that id");
            }
            return TypedResults.Ok();
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> UpdateBook(IBookRepository bookRepository, IAuthorRepository authorRepository, int id, BookPut model)
        {
            try
            {
                var book = await bookRepository.Get(id);
                if (book == null)
                {
                    return Results.NotFound();
                }
                if (model.Title != null) book.Title = model.Title;
                if (model.AuthorId != null) book.AuthorId = model.AuthorId;
                await bookRepository.Update(book.AuthorId, id);
                var author = await authorRepository.Get(model.AuthorId);
                BookDTO bookreturn = new BookDTO
                {
                    Id = book.Id,
                    Title = model.Title,
                    AuthorId = model.AuthorId,
                    Author = new AuthorDTO
                    {
                        Id = author.Id,
                        FirstName = author.FirstName,
                        LastName = author.LastName,
                        Email = author.Email
                    }
                };            
       
            return TypedResults.Ok(bookreturn);
            }
            catch (Exception e)
            {
                return TypedResults.BadRequest(e);
            }

        }
    }
}
