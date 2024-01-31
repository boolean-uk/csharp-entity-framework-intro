using exercise.webapi.DTOs;
using exercise.webapi.Models;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorApi(this WebApplication app)
        {
            var group = app.MapGroup("/authors");

            group.MapGet("/", GetAll);
            group.MapGet("/{id}", Get);
        }

        private async static Task<IResult> GetAll(IAuthorRepository repository)
        {
            return TypedResults.Ok(await repository.GetAll());
        }

        private async static Task<IResult> Get(IAuthorRepository repository, int id) 
        {
            try
            {
                GetAuthorDTO author = await repository.GetById(id);
                return TypedResults.Ok(author);
            } catch (ArgumentException ex)
            {
                return TypedResults.NotFound(ex.Message);
            }
        }
    }
}
