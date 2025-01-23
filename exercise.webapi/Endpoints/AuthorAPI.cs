using exercise.webapi.Models;
using exercise.webapi.Repository;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints;

public static class AuthorApi
{
    public static void ConfigureAuthorsApi(this WebApplication app)
    {
        app.MapGet("/author", GetAll);
        app.MapGet("/author/{id}", Get);
    }

    private static async Task<IResult> GetAll(IAuthorRepository repo)
    {
        var result = await repo.GetAll();
        var authors = result.Select(a => new AuthorDTO(a));
        return TypedResults.Ok(authors);
    }

    private static async Task<IResult> Get(IAuthorRepository repo, int id)
    {
        var result = await repo.Get(id);
        if (result == null)
        {
            return TypedResults.NotFound("Author with given id not found");
        }
        return TypedResults.Ok(new AuthorDTO(result));
    }
}
