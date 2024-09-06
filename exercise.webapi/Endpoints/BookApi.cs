using exercise.webapi.DTO;
using exercise.webapi.DTOS;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            var books = app.MapGroup("books");

            books.MapGet("/", GetBooks);
            books.MapGet("/{id}", GetBookById);
            books.MapPut("/{id}", UpdateBookAuthor);
            books.MapDelete("/{id}", DeleteBookById);
            books.MapPost("/create", CreateBook);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            GetAllBooksResponse response = new GetAllBooksResponse();
            var books = await bookRepository.GetAllBooks();

            foreach (Book book in books) 
            {
                DTOBookWithAuthor dtoBook = new DTOBookWithAuthor();
                dtoBook.Id = book.Id;
                dtoBook.Title = book.Title;

                DTOAuthorWithoutBooks dtoAuthor = new DTOAuthorWithoutBooks();
                dtoAuthor.Id = book.Author.Id;
                dtoAuthor.FirstName = book.Author.FirstName;
                dtoAuthor.LastName = book.Author.LastName;
                dtoAuthor.Email = book.Author.Email;

                dtoBook.Author = dtoAuthor;

                response.Books.Add(dtoBook);
            }

            return TypedResults.Ok(response.Books);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetBookById(IBookRepository bookRepository, int id)
        {
            try
            {
                var book = await bookRepository.GetBookById(id);

                DTOAuthorWithoutBooks dtoAuthor = new DTOAuthorWithoutBooks();
                dtoAuthor.Id = book.Author.Id;
                dtoAuthor.FirstName = book.Author.FirstName;
                dtoAuthor.LastName = book.Author.LastName;
                dtoAuthor.Email = book.Author.Email;

                DTOBookWithAuthor dtoBook = new DTOBookWithAuthor();
                dtoBook.Id = book.Id;
                dtoBook.Title = book.Title;
                dtoBook.Author = dtoAuthor;

                return TypedResults.Ok(dtoBook);
            }
            catch (Exception ex) 
            {
                return TypedResults.NotFound(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> UpdateBookAuthor(IBookRepository bookRepository, int id, AuthorPutModel author)
        {
            try
            {
                var target = await bookRepository.GetBookById(id);

                target.Author.FirstName = author.FirstName;
                target.Author.LastName = author.LastName;
                target.Author.Email = author.Email;

                await bookRepository.UpdateBookById(id, target);

                DTOAuthorWithoutBooks dtoAuthor = new DTOAuthorWithoutBooks() { 
                    Id = target.Author.Id, 
                    FirstName = target.Author.FirstName, 
                    LastName = target.Author.LastName, 
                    Email = target.Author.Email 
                };

                DTOBookWithAuthor dtoBook = new DTOBookWithAuthor() { 
                    Id = target.Id, 
                    Title = target.Title, 
                    Author = dtoAuthor 
                };

                return TypedResults.Ok(dtoBook);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status202Accepted)]
        public static async Task<IResult> DeleteBookById(IBookRepository bookRepository, int id)
        {
            try
            {
                var target = await bookRepository.GetBookById(id);

                await bookRepository.DeleteBookById(id);

                DTOAuthorWithoutBooks dtoAuthor = new DTOAuthorWithoutBooks()
                {
                    Id = target.Author.Id,
                    FirstName = target.Author.FirstName,
                    LastName = target.Author.LastName,
                    Email = target.Author.Email
                };

                DTOBookWithAuthor dtoBook = new DTOBookWithAuthor() { 
                    Id = target.Id, 
                    Title = target.Title, 
                    Author = dtoAuthor 
                };

                return TypedResults.Ok(dtoBook);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status202Accepted)]
        public static async Task<IResult> CreateBook(IBookRepository bookRepository, BookPostModel book)
        {
            try
            {
                Book newBook = new Book();

                newBook.Title = book.Title;
                newBook.AuthorId = book.AuthorId;

                await bookRepository.CreateBook(newBook);

                return TypedResults.Ok();
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
