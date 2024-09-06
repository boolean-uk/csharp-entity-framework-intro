using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {

        public static void ConfigureAuthorsApi(this WebApplication app)
        {
            var authors = app.MapGroup("authors");
            authors.MapGet("/authors", GetAuthors);
            authors.MapGet("/author", GetAuthor);

        }

        public static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            var entity = await authorRepository.GetAllAuthors();

            return TypedResults.Ok(entity);
        }

        public static async Task<IResult> GetAuthor(IAuthorRepository authorRepository, int id)
        {
            var entity = await authorRepository.GetAuthor(id);

            return TypedResults.Ok(entity);
        }
    }
}
