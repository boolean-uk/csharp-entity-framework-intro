using exercise.webapi.Models;
using exercise.webapi.Repository;
using System.Runtime.CompilerServices;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorsApi(this WebApplication app)
        {
            app.MapGet("/authors/", GetAuthors);
            app.MapGet("/authors/{id}", GetAuthorById);
        }

        private static async Task<IResult> GetAuthorById(IAuthorRepository authorRepository, int id)
        {
            var result = await authorRepository.GetAuthorById(id);
            return TypedResults.Ok(result);
        }

        private static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            var result = await authorRepository.GetAuthors();
            return TypedResults.Ok(result);
        }
    }
}
