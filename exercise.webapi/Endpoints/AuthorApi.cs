using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {


        public static void ConfigureAuthorApi(this WebApplication app)
        {
            app.MapGet("/Authors", GetAuthors);
            app.MapGet("/Author/{id}", GetAuthor);

        }
        private static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            var Authors = await authorRepository.GetAllAuthors();
            return TypedResults.Ok(Authors);
        }
        private static async Task<IResult> GetAuthor(IAuthorRepository authorRepository, int id)
        {
            var Author = await authorRepository.GetAuthor(id);
            return TypedResults.Ok(Author);
        }
    }
}
