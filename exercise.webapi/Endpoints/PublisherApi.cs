using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;
using exercise.webapi.Models.DTOs;

namespace exercise.webapi.Endpoints;

public static class PublisherApi
{
    public static void ConfigurePublisherApi(this WebApplication app)
    {
        var group = app.MapGroup("publishers");

        group.MapGet("/", GetPublishers);
        group.MapGet("/{id}", GetPublisher);
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    private static async Task<IResult> GetPublishers(IPublisherRepository publisherRepository)
    {
        var publishers = await publisherRepository.GetAllPublishers();
        var returnList = new List<PublisherWithBooksAndAuthorDTO>();
        foreach (var publisher in publishers)
        {
            returnList.Add(PublisherWithBooksAndAuthorDTO.PublisherToDTO(publisher));
        }
        return TypedResults.Ok(returnList);
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    private static async Task<IResult> GetPublisher(IPublisherRepository publisherRepository, int id)
    {
        var publisher = await publisherRepository.GetPublisherById(id);

        if (publisher == null)
        {
            return TypedResults.NotFound($"Id: {id} not found!");
        }

        return TypedResults.Ok(PublisherWithBooksAndAuthorDTO.PublisherToDTO(publisher));
    }
}
