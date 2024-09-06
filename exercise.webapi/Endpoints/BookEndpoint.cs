using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookEndpoint
    {
        public static void ConfigureBooksEndpoint(this WebApplication app)
        {
            app.MapGet("/books/GetAll", GetBooks);
            app.MapGet("/books/GetBook{id}", GetBook);
            app.MapPut("/books/Update", Update);
            app.MapDelete("/books/DeleteBook{id}", DeleteBook);
            app.MapPost("/books/AddBook", AddBook);
            app.MapPut("/books/AssignAuthor", AssignAuthor);
            app.MapDelete("/books/RemoveAuthor", RemoveAuthor);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> AddBook(IBookRepository repository, BookPost data)
        {
            bool foundBook = await repository.CheckBookDataId(data);
            if(!foundBook)
            {
                return TypedResults.NotFound();
            }
            if(data.title == "" || data.title == null)
            {
                return TypedResults.BadRequest();
            }
            var result = await repository.AddBook(data);
            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> DeleteBook(IBookRepository repository, int id)
        {
            var result = await repository.DeleteBook(id);
            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> Update(IBookRepository repository, int id, BookUpdate data)
        {
            var result = await repository.UpdateBook(id, data);
            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> RemoveAuthor(IBookRepository repository, int id, int authorId)
        {
            var result = await repository.RemoveAuthorFromBook(id, authorId);
            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> AssignAuthor(IBookRepository repository, int id, int authorId)
        {
            var result = await repository.AssignAuthorToBook(id, authorId);
            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBook(IBookRepository repository, int id)
        {
            var result = await repository.GetBook(id);
            return TypedResults.Ok(result);   
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBooks(IBookRepository repository)
        {
            var result = await repository.GetAllBooks();
            return TypedResults.Ok(result);
        }
    }
}
