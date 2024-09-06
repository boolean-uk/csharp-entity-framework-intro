using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorApi(this WebApplication app)
        {
            app.MapGet("/authors", GetAuthors);
            app.MapGet("/authors/{id}", GetAuthor);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAuthors(IRepository<Author, AuthorDTO> authorRepository)
        {
            var authors = await authorRepository.GetAll();
            List<AuthorResponse> response = new List<AuthorResponse>();
            foreach (var author in authors)
            {
                response.Add(ResponseGenerator.GenerateAuthorResponse(author));
            }
            return TypedResults.Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetAuthor(IRepository<Author, AuthorDTO> authorRepository, int id)
        {
            Author author = await authorRepository.Get(id);
            return author != null ? TypedResults.Ok(ResponseGenerator.GenerateAuthorResponse(author)) : TypedResults.NotFound("Not found");
        }
    }
}
