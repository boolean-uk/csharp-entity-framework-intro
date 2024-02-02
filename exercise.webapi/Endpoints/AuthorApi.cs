using exercise.webapi.AlternativeModels;
using exercise.webapi.Conversions;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorssApi(this WebApplication app)
        {
            var authors = app.MapGroup("/author");

            authors.MapGet("/{id}", GetAuthor);
            authors.MapGet("/", GetAuthors);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetAuthor(IAuthorRepository authorRepository, int id)
        {
            var author = await authorRepository.GetAuthor(id);
            if (author == null) return TypedResults.NotFound();

            return TypedResults.Ok();
        }

        private static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            var authors = await authorRepository.GetAuthors();

            List<AAuthorDto> result = AuthorConversion.toAuthor(authors);

            return TypedResults.Ok(result);
        }

    }
}
