
using exercise.webapi.Models.DTOs;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorApi(this WebApplication app)
        {
            app.MapGroup("/authors");
            app.MapGet("/authors", GetAuthors);
        }

        private static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            var books = AuthorResponseDTO.FromRepository(await authorRepository.GetAllAuthors());
            return TypedResults.Ok(books);
        }
    }
}