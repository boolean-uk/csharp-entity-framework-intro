using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class AuthorAPI
    {
        public static void ConfigureAuthorApi(this WebApplication app)
        {
            var authors = app.MapGroup("authors/");
            authors.MapGet("/", GetAllAuthors);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAllAuthors()
        {
            throw new NotImplementedException();
        }
    }
}
