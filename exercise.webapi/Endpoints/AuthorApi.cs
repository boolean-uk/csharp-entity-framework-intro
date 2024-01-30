using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Builder;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorsApi(this WebApplication app)
        {
            app.MapGet("/author", GetAuthors);
            app.MapGet("/author{id}", GetAuthor);
        }

        private static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            var author = await authorRepository.GetAllAuthors();
            return TypedResults.Ok(AuthorResponseDTO.FromRepository(author));
        }

        private static async Task<IResult> GetAuthor(IAuthorRepository authorRepository, int id)
        {
            var author = await authorRepository.GetAuthor(id);
            if (author == null)
                return Results.NotFound("Id out of scope");

            return TypedResults.Ok(AuthorResponseDTO.FromARepository(author));
        }
    }
}
