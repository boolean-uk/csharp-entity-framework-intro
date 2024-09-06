using exercise.webapi.CreateModels;
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
            var book = app.MapGroup("books");
            book.MapGet("/", GetBooks);
            book.MapGet("/{id}", GetABook);
            book.MapPut("/{id}", UpdateABook);
            book.MapDelete("/{id}", DeleteABook);
            book.MapPost("/{id}", CreateABook);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            GetBookResponse response = new();

            var books = await bookRepository.GetAllBooks();

            foreach (Book book in books)
            {
                DTOBook b = new();
                b.Title = book.Title;
                b.AuthorName = book.Author.FirstName + " " + book.Author.LastName;

                response.Books.Add(b);
            }

            return TypedResults.Ok(response);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetABook(IBookRepository repo, int id)
        {
            try
            {
                GetBookResponse response = new();

                var book = await repo.GetById(id);
                DTOBook bookObject = new()
                {
                    Title = book.Title,
                    AuthorName = book.Author.FirstName + " " + book.Author.LastName
                };

                response.Books.Add(bookObject);

                return TypedResults.Ok(bookObject);
            }
            catch (Exception ex)
            {
                return TypedResults.BadRequest(ex.Message);
            }
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> UpdateABook(IBookRepository repo, int id, DTOAuthor author)
        {
            try
            {

                var result = await repo.UpdateById(id, author.AuthorId);

                var foundBook = await repo.GetById(id);

                DTOBook bookObject = new()
                {
                    Title = foundBook.Title,
                    AuthorName = foundBook.Author.FirstName + " " + foundBook.Author.LastName
                };

                return TypedResults.Ok(bookObject);
            }
            catch (Exception ex)
            {
                return TypedResults.BadRequest(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> DeleteABook(IBookRepository repo, int id)
        {
            try
            {
                var result = await repo.DeleteById(id);
                return TypedResults.Ok(result);
            }
            catch (Exception ex)
            {
                return TypedResults.BadRequest(ex.Message);
            }
        }
        
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> CreateABook(IBookRepository repo, CreateBookModel bookInput)
        {
            try
            {
                if (!await repo.ContainsAuthor(bookInput.AuthorId))
                {
                    return TypedResults.NotFound("Author Id is not valid");
                }
                var result = await repo.Create(new Book() 
                {
                    Title = bookInput.Title,
                    AuthorId = bookInput.AuthorId
                });
                return TypedResults.Created();
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
        

    }
}
