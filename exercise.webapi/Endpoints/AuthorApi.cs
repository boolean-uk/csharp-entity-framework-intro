using exercise.webapi.Models;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class AuthorAPI
    {
        public static void ConfigureAuthorsApi(this WebApplication app)
        {
            var authors = app.MapGroup("authors");
            authors.MapGet("/", GetAuthors);
            authors.MapGet("/{id}", GetAuthor);
        }

        private static async Task<IResult> GetAuthor(IAuthorRepository repository, int id)
        {
            var author = repository.GetAuthor(id);
            return TypedResults.Ok(author);
        }

        private static async Task<IResult> GetAuthors(IAuthorRepository repository)
        {
            var authors = repository.GetAll();
            return TypedResults.Ok(authors);
        }
    }
}
