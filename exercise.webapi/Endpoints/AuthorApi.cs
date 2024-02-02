using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorsApi(this WebApplication app)
        {
            var group = app.MapGroup("authors");
            group.MapGet("/", GetAuthors);
            group.MapGet("/{id}", GetAuthor);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            IEnumerable<Author> authors = await authorRepository.GetAll();
            List<AuthorDto> authorDtos = authors.Select(a => a.ToDto()).ToList();
            return TypedResults.Ok(authorDtos);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetAuthor(IAuthorRepository authorRepository, int id)
        {
            var author = await authorRepository.Get(id);
            return author == null ? TypedResults.NotFound() : TypedResults.Ok(author.ToDto());
        }
    }
}