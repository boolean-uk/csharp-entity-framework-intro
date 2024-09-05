using exercise.webapi.Repository;
using Microsoft.AspNetCore.Builder;

namespace exercise.webapi.Endpoints
{
    public static class AuthorEndpoint
    {
        public static void ConfigureAuthorsEndpoint(this WebApplication app)
        {
            app.MapGet("/authors/GetAuthors", GetAuthors);
            app.MapGet("/authors/GetAuthor{id}", GetAuthor);
        }


        private static async Task<IResult> GetAuthors(IAuthorRepository repository)
        {
            var result = await repository.GetAll();
            return TypedResults.Ok(result);
        }
        private static async Task<IResult> GetAuthor(IAuthorRepository repository, int id)
        {
            var result = await repository.GetAuthor(id);
            return TypedResults.Ok(result);
        }
    }
}
