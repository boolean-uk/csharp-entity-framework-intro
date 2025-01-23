using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorApi(this WebApplication app)
        {
            app.MapGet("/authors", GetAll);
            app.MapGet("/author", Get);
        }
        public static async Task<IResult> GetAll(IBookRepository repo)
        {
            var authors = repo.GetAllAuthors();
            return TypedResults.Ok(authors);  
        }
        public static async Task<IResult> Get(IBookRepository repo, int id)
        {
            var author = repo.GetAuthor(id);
            return TypedResults.Ok(author);
        }
    }
}
