using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorsApi(this WebApplication app)
        {
            var authorGroup = app.MapGroup("authors");
            authorGroup.MapGet("", GetAuthors);
            authorGroup.MapGet("{id}", GetAuthor);
        }

        private static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            return TypedResults.Ok(await authorRepository.GetAllAuthors());
        }

        private static async Task<IResult> GetAuthor(IAuthorRepository authorRepository, int id)
        {
            return TypedResults.Ok(await authorRepository.GetAuthorDetail(id));
        }
    }
}
