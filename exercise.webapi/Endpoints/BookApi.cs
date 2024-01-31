using exercise.webapi.Models;
using exercise.webapi.Models.DatabaseModels;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {


        public static void ConfigureBooksApi(this WebApplication app)
        {
            var group = app.MapGroup("book");

            group.MapGet("/books", GetBooks);
            group.MapGet("/{id}", GetBook);
            group.MapPut("{id}", UpdateBook);
            group.MapDelete("/{id}", DeleteBook);
            group.MapPost("/", AddNewBook);



        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            return TypedResults.Ok(books);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetBook([FromServices] IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetBook(id);
            if (book == null)
            {
                return Results.NotFound();
            }
            return TypedResults.Ok(book);
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> UpdateBook([FromServices] IBookRepository bookRepository, int id, [FromBody] int newAuthorId)
        {
            var updatedBook = await bookRepository.UpdateBook(id, newAuthorId);

            if (updatedBook == null)
            {
                return Results.NotFound();
            }

            return TypedResults.Ok(updatedBook);
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteBook([FromServices] IBookRepository bookRepository, int id)
        {
            var deletedBook = await bookRepository.DeleteBook(id);

            if (deletedBook == null)
            {
                return Results.NotFound();
            }

            return Results.Ok();
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> AddNewBook([FromServices] IBookRepository bookRepository, [FromBody] BookDto bookDto)
        {
            if (bookDto == null)
            {
                // Handle null bookDto
                return Results.BadRequest("Invalid book object.");
            }

            // Validate author ID
            if (bookDto.Author == null || bookDto.Author.Id <= 0)
            {
                // Return BadRequest if author ID is not valid
                return Results.BadRequest("Invalid author ID.");
            }

            // Validate other properties of bookDto if needed

            // Attempt to add the book
            var addedBook = await bookRepository.AddBook(bookDto);

            if (addedBook == null)
            {
                // Handle case where book couldn't be added (e.g., invalid author)
                return Results.NotFound();
            }

            // Return the newly added book with a 201 Created response
            return TypedResults.Created($"/book/{addedBook.Id}", addedBook);
        }




    }
}
