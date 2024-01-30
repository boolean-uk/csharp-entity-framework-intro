using exercise.webapi.DTO.AuthorDTO;
using exercise.webapi.Repository.AuthorRepo;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorApi(this WebApplication app)
        {
            var authors = app.MapGroup("/authors");
            authors.MapGet("", GetAuthors);
            authors.MapGet("/{id}", GetAuthorById);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetAuthorById(IAuthorRepository authorRepository, int authorID)
        {
            var author = await authorRepository.GetByIdAsync(authorID);
            if (author == null) { return TypedResults.NotFound($"Author id {authorID} not found"); }

            var result = new AuthorDTO(author);
            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            var author = AuthorDTO.FromRepository(await authorRepository.GetAllAsync());
            return author == null ? TypedResults.NotFound() : TypedResults.Ok(author);
        }
    }
}
