using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class AuthorAPI
    { 
        public static void ConfigureAuthorEndpoints(this WebApplication app)
        {
            var authors = app.MapGroup("authors");
            authors.MapGet("/", GetAuthors);
            authors.MapGet("/{id}", GetAuthor);

        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAuthors(IAuthorRepository rep)
        {
            var authors = await rep.GetAuthors();
            return TypedResults.Ok(authors);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAuthor(IAuthorRepository rep, int id)
        {
            var author = await rep.GetAnAuthor(id);

            return TypedResults.Ok(author);

        }



    }
}
