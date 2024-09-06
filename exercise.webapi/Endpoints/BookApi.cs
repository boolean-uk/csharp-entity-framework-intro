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
            books.MapPut("/update/{id}", UpdateBookAuthor);
            books.MapDelete("/delete/{id}", DeleteBookById);
            books.MapPost("/create", CreateBook);
            books.MapPut("/{id}/removeAuthor", RemoveAuthorFromBook);
            //books.MapPut("/{id}/assignAuthor", AssignAuthorToBook);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            GetAllBooksResponse response = new GetAllBooksResponse();
            var books = await bookRepository.GetAllBooks();

            foreach (Book book in books) 
            {
                DTOAuthorWithoutBooks dtoAuthor = new DTOAuthorWithoutBooks() 
                {
                    Id = book.Author.Id,
                    FirstName = book.Author.FirstName,
                    LastName = book.Author.LastName,
                    Email = book.Author.Email
                };

                DTOBookWithAuthor dtoBook = new DTOBookWithAuthor()
                {
                    Id = book.Id,
                    Title = book.Title,
                    Author = dtoAuthor
                };

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

                if (book == null)
                {
                    return TypedResults.NotFound("Target not found");
                }

                DTOAuthorWithoutBooks dtoAuthor = new DTOAuthorWithoutBooks() 
                {
                    Id = book.Author.Id,
                    FirstName = book.Author.FirstName,
                    LastName = book.Author.LastName,
                    Email = book.Author.Email
                };

                DTOBookWithAuthor dtoBook = new DTOBookWithAuthor() 
                {
                    Id = book.Id,
                    Title = book.Title,
                    Author = dtoAuthor
                };

                return TypedResults.Ok(dtoBook);
            }
            catch (Exception ex) 
            {
                return TypedResults.NotFound(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> UpdateBookAuthor(IBookRepository bookRepository, int id, AuthorPutModel author)
        {
            try
            {
                var target = await bookRepository.GetBookById(id);

                target.Author.FirstName = author.FirstName;
                target.Author.LastName = author.LastName;
                target.Author.Email = author.Email;

                await bookRepository.UpdateBookById(target);

                DTOAuthorWithoutBooks dtoAuthor = new DTOAuthorWithoutBooks() 
                { 
                    Id = target.Author.Id, 
                    FirstName = target.Author.FirstName, 
                    LastName = target.Author.LastName, 
                    Email = target.Author.Email 
                };

                DTOBookWithAuthor dtoBook = new DTOBookWithAuthor() 
                { 
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
        [ProducesResponseType(StatusCodes.Status404NotFound)]
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

                DTOBookWithAuthor dtoBook = new DTOBookWithAuthor() 
                { 
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
                Book newBook = new Book() 
                {
                    Title = book.Title,
                    AuthorId = book.AuthorId
                };

                var createdBook = await bookRepository.CreateBook(newBook);
                var response = await bookRepository.GetBookById(createdBook.Id);

                DTOAuthorWithoutBooks dtoAuthor = new DTOAuthorWithoutBooks() 
                { 
                    Id = response.Author.Id,
                    FirstName = response.Author.FirstName,
                    LastName = response.Author.LastName,
                    Email = response.Author.Email
                };

                DTOBookWithAuthor dtoBook = new DTOBookWithAuthor()
                {
                    Id = response.Id,
                    Title = response.Title,
                    Author = dtoAuthor
                };

                return TypedResults.Ok(dtoBook);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        public static async Task<IResult> RemoveAuthorFromBook(IBookRepository bookRepository, int id)
        {
            try
            {
                var target = await bookRepository.RemoveAuthorFromBookById(id);

                return TypedResults.Ok(target);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
