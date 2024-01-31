using exercise.webapi.Models;
using exercise.webapi.Repository;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorApi(this WebApplication app)
        {
            app.MapGet("/Author", GetAuthor);
            app.MapGet("/getAnAuthor/{id}", GetAnAuthor);
        }

        private static async Task<IResult> GetAuthor(IAuthorRepository authorRepository)
        {
            return TypedResults.Ok(AuthorResponseDTO.FromRepository(await authorRepository.GetAllAuthors()));
        }

        private static async Task<IResult> GetAnAuthor(IAuthorRepository authorRepository, int authorId)
        {
            return TypedResults.Ok(AuthorResponseDTO.FromRepository(await authorRepository.GetAnAuthor(authorId)));
        }
    }
}
