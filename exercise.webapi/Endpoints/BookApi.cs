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
            books.MapGet("/{id}", GetBook);
            books.MapPost("/", AddBook);
            books.MapPut("/{id}", UpdateBook);
            books.MapDelete("/{id}", DeleteBook);
        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            var bookDTO = books.Select(book => new BookDTO
            {
                Id = book.Id,
                Title = book.Title,
                AuthorId = book.AuthorId,
                Author = new MinimalAuthorDTO
                {
                    Id = book.Author.Id,
                    FirsName = book.Author.FirstName,
                    LastName = book.Author.LastName,
                    Email = book.Author.Email,
                }
            }).ToList();

            return TypedResults.Ok(bookDTO);
        }
        private static async Task<IResult> GetBook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetBook(id);
            if (book == null)
            {
                return TypedResults.NotFound();
            }
            var bookDTOs = new BookDTO
            {
                Id = book.Id,
                Title = book.Title,
                Author = new MinimalAuthorDTO
                {
                    Id = book.Author.Id,
                    FirsName= book.Author.FirstName,
                    LastName = book.Author.LastName,
                    Email = book.Author.Email,
                }
            };
            return TypedResults.Ok(bookDTOs);
        }
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> AddBook(IBookRepository bookRepository, IAuthorRepository authorRepository, PostBook model)
        {
            try
            {

                var author = await authorRepository.GetAuthor(model.AuthorId);
                if (author == null)
                {
                    return TypedResults.NotFound("Author not found");
                }
                if (string.IsNullOrEmpty(model.Title))
                {
                    return TypedResults.BadRequest("Title is empty");
                }
                Book book = new Book()
                {
                    Title = model.Title,
                    AuthorId = model.AuthorId
                };
                await bookRepository.AddBook(book);
               
                var bookDTOs = new BookDTO
                {
                    Id = book.Id,
                    Title = book.Title,
                    AuthorId = book.AuthorId,
                    Author = new MinimalAuthorDTO
                    {
                        Id = book.Author.Id,
                        FirsName = book.Author.FirstName,
                        LastName = book.Author.LastName,
                        Email = book.Author.Email,
                    }
                };

                return TypedResults.Created($"https://localhost:7010/products/{book.Id}", bookDTOs);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> UpdateBook(IBookRepository bookRepository, IAuthorRepository authorRepository, int id, PutBook model)
        {
            try
            {
                var target = await bookRepository.GetBook(id);
                if (target == null) return Results.NotFound("Book not found");

                Author authorTarget = null; 

                if (model.AuthorId != null)
                {
                    authorTarget = await authorRepository.GetAuthor((int)model.AuthorId);
                    target.AuthorId = (int)model.AuthorId;
                    target.Author = authorTarget;
                }

                if (!string.IsNullOrEmpty(model.Title)) target.Title = model.Title;

                await bookRepository.UpdateBook(target);
                
                var bookDTOs = new BookDTO
                {
                    Id = target.Id,
                    Title = target.Title,
                    AuthorId = target.AuthorId,
                    Author = new MinimalAuthorDTO
                    {
                        Id = target.Author.Id,
                        FirsName = target.Author.FirstName,
                        LastName = target.Author.LastName,
                        Email = target.Author.Email,
                    }
                };
                return TypedResults.Ok(bookDTOs);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
        public static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            try
            {
                var target = await bookRepository.GetBook(id);
                if (await bookRepository.DeleteBook(id)) return Results.Ok($"Book: {target.Title} Deleted");
                return TypedResults.NotFound("Book not found");
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
