using System;
using exercise.webapi.DTO;
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
            books.MapGet("/{id}", GetBook);
            books.MapPost("/", AddBook);
            books.MapDelete("/{id}", DeleteBook);
            books.MapPut("/{id}", UpdateBook);
        }

        #region Get books
        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            //Payload<List<Book>> payload = new Payload<List<Book>>();


            var results = await bookRepository.GetAllBooks();
            var resultsDTO = results.Select(b => new BookDTO
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

            return TypedResults.Ok(resultsDTO);
        }

        public static async Task<IResult> GetBook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetBook(id);
            if (book == null)
            {
                return Results.NotFound();
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
            return Results.Ok(bookDTO);
           
        }
        #endregion

        #region Add book
        public static async Task<IResult> AddBook(IBookRepository bookRepository,IAuthorRepository authorRepository, BookPost model)
        {
            try
            {
                var author = await authorRepository.GetAuthor(model.AuthorId);
                Book book = new Book
                {
                    Title = model.Title,
                    AuthorId = model.AuthorId
                };
                
                
                await bookRepository.AddBook(book);

                BookDTO book2 = new BookDTO
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

                return TypedResults.Ok(book2);
            }

            catch (Exception e)
            {
                return TypedResults.Problem(e.Message);
            }
           
        }
        #endregion

        #region Delete book
        public static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            try
            {
                var book = await bookRepository.GetBook(id);
                var result = await bookRepository.DeleteBook(id);
                if (result)
                {
                    return Results.Ok(new { When = DateTime.Now, Status = "Deleted", Title = book.Title, AuthorId = book.AuthorId });
                }
                return Results.NotFound();
            }
            catch (Exception e)
            {
                return TypedResults.Problem(e.Message);
            }
           
        }
        #endregion

        #region Update book
        public static async Task<IResult> UpdateBook(IBookRepository bookRepository, IAuthorRepository authorRepository, int id, BookPut model)
        {
            try
            {
                var book = await bookRepository.GetBook(id);
                if (book == null)
                {
                    return Results.NotFound();
                }
                if (model.Title != null) book.Title = model.Title;
                if (model.AuthorId != null) book.AuthorId = model.AuthorId.Value;
                await bookRepository.UpdateBook(id, book);
                return Results.Ok(book);
            }
            catch (Exception e)
            {
                return TypedResults.Problem(e.Message);
            }
        }
        #endregion

    }
}
