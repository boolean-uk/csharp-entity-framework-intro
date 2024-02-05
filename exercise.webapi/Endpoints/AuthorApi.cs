using exercise.webapi.Models.DatabaseModels;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;
using exercise.webapi.Models.DataTransfer.Books;
using exercise.webapi.Models.DataTransfer.Authors;
using exercise.webapi.Models.DataTransfer;
using exercise.webapi.Models.JunctionModels;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorApi(this WebApplication app)
        {
            var authorGroup = app.MapGroup("author");

            authorGroup.MapGet("/", GetAuthors);
            authorGroup.MapGet("/{id}", GetSpecificAuthor);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetAuthors(IRepository<Author> repo)
        {
            var authors = await repo.GetAll();
            IEnumerable<AuthorDTO> results = authors.ToList().Select(a => new AuthorDTO(a.AuthorId, a.FirstName, a.LastName, a.Email, a.GetBooks())).ToList();
            Payload<IEnumerable<AuthorDTO>> payload = new Payload<IEnumerable<AuthorDTO>>(results);
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetSpecificAuthor(IRepository<Author> repo, int id)
        {
            var author = await repo.Get(id);
            if (author == null)
            {
                return TypedResults.NotFound("No author of provided BookId could be found.");
            }

            AuthorDTO authorOut = new AuthorDTO(author.AuthorId, author.FirstName, author.LastName, author.Email, author.GetBooks());

            Payload<AuthorDTO> payload = new Payload<AuthorDTO>(authorOut);
            return TypedResults.Ok(payload);
        }
    }
}
