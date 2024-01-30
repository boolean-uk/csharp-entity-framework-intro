using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorsApi(this WebApplication app)
        {
            app.MapGet("/authors", GetAuthors);
            app.MapGet("/author", GetAuthor);
        }
        private static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            var authors = GetAuthorDTO.FromRepository(await authorRepository.GetAllAuthors());
            return TypedResults.Ok(authors);
        }
        private static async Task<IResult> GetAuthor(IAuthorRepository authorRepository, int id)
        {
            var author = new GetAuthorDTO(await authorRepository.GetAuthor(id));
            return TypedResults.Ok(author);
        }
    }
}
