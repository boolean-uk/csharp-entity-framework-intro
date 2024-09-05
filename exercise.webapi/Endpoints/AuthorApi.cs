using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorsApi(this WebApplication app)
        {
            var authors = app.MapGroup("authors");
            authors.MapGet("/", GetAuthors);
            authors.MapGet("/{id}", GetAuthor);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            var books = await authorRepository.GetAllAuthors();
            return TypedResults.Ok(books);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAuthor(IAuthorRepository authorRepository, int id)
        {
            var book = await authorRepository.GetAuthor(id);
            return TypedResults.Ok(book);
        }
    }
}
