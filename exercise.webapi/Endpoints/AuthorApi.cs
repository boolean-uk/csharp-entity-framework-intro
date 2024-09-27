using exercise.webapi.Repository;
using exercise.webapi.DTO;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{

 public static class AuthorApi
    {
        public static void ConfigureAuthorApi(this WebApplication app)
        {
            app.MapGet("/authors", GetAuthors);
            app.MapGet("/authors/{id}", GetAuthorById);
        }

        private static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            var authors = await authorRepository.GetAllAuthors();
            return TypedResults.Ok(AutherResponseDto.FromRepository(authors));
        }

        private static async Task<IResult> GetAuthorById(IAuthorRepository authorRepository, int id)
        {
            var author = await authorRepository.GetAuthorById(id);
            if (author == null)
            {
                return Results.NotFound();
            }
            return TypedResults.Ok(new AutherResponseDto(author));
        }

    }
}