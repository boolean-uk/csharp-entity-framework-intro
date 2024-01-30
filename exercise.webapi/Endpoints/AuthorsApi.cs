using exercise.webapi.Repository;
using static System.Reflection.Metadata.BlobBuilder;
using exercise.webapi.DTO;

namespace exercise.webapi.Endpoints
{
    public static class AuthorsApi
    {

        public static void ConfigureAuthorsApi(this WebApplication app)
        {
            app.MapGet("/authors", GetAuthors);
            app.MapGet("/authors/{id}", GetAuthor);
        }

        public static async Task<IResult> GetAuthors(IAuthorsRepository authorsRepository)
        {
            return TypedResults.Ok(AuthorResponseDTO.FromRepository(await authorsRepository.GetAllAuthors()));
        }

        private static async Task<IResult> GetAuthor(IAuthorsRepository authorRepository, int authId)
        {
            var auth = await authorRepository.GetAuthor(authId);

            return TypedResults.Ok(new AuthorSingleDTO(auth));
        }

    }
}
