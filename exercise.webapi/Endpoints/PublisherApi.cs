using exercise.webapi.Models;
using exercise.webapi.Repository;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints;

public static class PublisherApi
{
    public static void ConfigurePublisherApi(this WebApplication app)
    {
        app.MapGet("/publisher", GetAll);
        app.MapGet("/publisher/{id}", Get);
    }

    private static async Task<IResult> GetAll(IPublisherRepository repo)
    {
        var result = await repo.GetAll();
        var authors = result.Select(p => new PublisherDTO(p));
        return TypedResults.Ok(authors);
    }

    private static async Task<IResult> Get(IPublisherRepository repo, int id)
    {
        var result = await repo.Get(id);
        if (result == null)
        {
            return TypedResults.NotFound("Publisher with given id not found");
        }
        return TypedResults.Ok(new PublisherDTO(result));
    }
}
