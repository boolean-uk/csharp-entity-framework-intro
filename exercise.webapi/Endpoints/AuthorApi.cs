using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorApi(this WebApplication app)
        {
            var books = app.MapGroup("books");
            books.MapGet("/", GetAllAuthors);
            books.MapGet("/{id}", GetAuthorById);
        }

        private static async Task<IResult> GetAllAuthors(IAuthorRepository authorRepository)
        {
            var books = await authorRepository.GetAllAuthors();
            return TypedResults.Ok(books);
        }

        private static async Task<IResult> GetAuthorById(IAuthorRepository authorRepository, int id)
        {
            var book = await authorRepository.GetAuthorById(id);
            return TypedResults.Ok(book);
        }
    }
}
