using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorApi(this WebApplication app)
        {
            app.MapGet("/authors", GetAuthors);
            app.MapGet("/authors/{id}", GetAuthorById);
        }

        private static async Task<IResult> GetAuthorById(int id, IAuthorRepository authorRepository)
        {
            var books = await authorRepository.GetAuthorById(id);
            if (books == null) { return TypedResults.NotFound("Author not found"); }
            return TypedResults.Ok(books);
        }

        private static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            var books = await authorRepository.GetAllAuthors();
            return TypedResults.Ok(books);
        }
    }
}
