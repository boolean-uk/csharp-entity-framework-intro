using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorApi(this WebApplication app)
        {
            app.MapGet("/authors", GetAuthors);
            app.MapGet("/authors/{id}", GetAuthorById);
        }

        private static async Task<IResult> GetAuthors([FromServices] IAuthorRepository authorRepository)
        {
            var authors = await authorRepository.GetAllAuthors();
            return Results.Ok(authors);
        }

        private static async Task<IResult> GetAuthorById([FromServices] IAuthorRepository authorRepository, int id)
        {
            try
            {
                var author = await authorRepository.GetAuthorById(id);
                return Results.Ok(author);
            }
            catch (KeyNotFoundException ex)
            {
                return Results.NotFound(new { message = ex.Message });
            }
        }
    }
}
