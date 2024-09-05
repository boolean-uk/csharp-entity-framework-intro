
namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorsApi(this WebApplication app)
        {
            app.MapGet("/books", GetAuthors);
            app.MapGet("/books/{id:int}", GetSingleAuthor);

        }

        private static async Task GetSingleAuthor(int id)
        {
            throw new NotImplementedException();
        }

        private static async Task GetAuthors()
        {
            throw new NotImplementedException();
        }
    }
}
