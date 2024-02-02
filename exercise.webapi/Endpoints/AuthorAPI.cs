using exercise.webapi.Models.BaseModels;
using exercise.webapi.Models.DataTransfer.Author;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class AuthorAPI
    {
        public static void ConfigureAuthorsApi(this WebApplication app)
        {
            var group = app.MapGroup("authors");
            group.MapGet("/", GetAll);
            group.MapGet("/{id}", Get);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAll(IRepository<Author> authorRespository)
        {
            var authors = await authorRespository.GetAll();
            List<AuthorDetailedDTO> results = new List<AuthorDetailedDTO>();
            foreach (var author in authors)
            {
                results.Add(new AuthorDetailedDTO(author));
            }
            return TypedResults.Ok(results);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> Get(IRepository<Author> authorRespository, int id)
        {
            var author = await authorRespository.Get(id);
            return TypedResults.Ok(new AuthorDetailedDTO(author));
        }
    }
}
