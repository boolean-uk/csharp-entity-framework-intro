using exercise.webapi.Models;
using exercise.webapi.Repository;
using exercise.webapi.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints;

public static class PublisherApi
{
    public static void ConfigurePublishersApi(this WebApplication app)
    {
        var publishers = app.MapGroup("publisher");
        publishers.MapGet("/", GetPublishers);
        publishers.MapPost("/", AddPublisher);
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    private static async Task<IResult> GetPublishers(IRepository<Publisher> repo)
    {
        var list = await repo.GetAll();
        return TypedResults.Ok(list);
    }

    private static async Task<IResult> AddPublisher(IRepository<Publisher> repo, PostPublisherModel publisher)
    {
        Publisher newEntity = new() { Name = publisher.Name };
        await repo.Add(newEntity);
        return TypedResults.Ok(newEntity);
    }
}