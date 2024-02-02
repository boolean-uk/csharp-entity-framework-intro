using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class AuthorEndpoint
    {
        public static void ConfigureAuthorEndpoint(this WebApplication app)
        {
            var authorGroup = app.MapGroup("authors");

            app.MapGet("/authors", GetAuthors);
            app.MapGet("/authors/{id}", GetBooksByAuthorId);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAuthors(IBookRepository bookRepository)
        {
            var authors = await bookRepository.GetAllAuthors();
            return TypedResults.Ok(authors);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetBooksByAuthorId(IBookRepository bookRepository, int id)
        {
            var books = await bookRepository.GetBooksByAuthorId(id);

            if (books == null)
            {
                return TypedResults.NotFound("Book with provided id doesn't exists");
            }
            return TypedResults.Ok(books);
        }
    }
}
