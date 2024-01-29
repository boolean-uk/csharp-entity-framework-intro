using exercise.webapi.Models;
using exercise.webapi.Repository;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorApi(this WebApplication app)
        {
            app.MapGet("/Author", GetBooks);
            app.MapGet("/getAnAuthor/{id}", GetABook);
        }

        private static async Task<IResult> GetBooks(IAuthorRepository authorRepository)
        {
            return TypedResults.Ok(AuthorResponseDTO.FromRepository(await authorRepository.GetAllAuthors()));
        }

        private static async Task<IResult> GetABook(IAuthorRepository authorRepository, int authorId)
        {
            return TypedResults.Ok(AuthorResponseDTO.FromRepository(await authorRepository.GetAnAuthor(authorId)));
        }
    }
}
