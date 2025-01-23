using System;
using System.Xml.Serialization;
using exercise.webapi.DTO;
using exercise.webapi.Payload;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints;

public static class PublisherAPI
{

    public static void ConfigurePublisherApi(this WebApplication app)
    {
        var publisher = app.MapGroup("/publishers");

        publisher.MapGet("/", GetPublishers);
        publisher.MapGet("/{id}", GetPublisher);


    }   

    [ProducesResponseType(StatusCodes.Status200OK)]
    public static async Task<IResult> GetPublishers(IPublisherRepository publisherRepository)
    {
        Payload<List<PublisherGetDTO>> payload = await publisherRepository.GetPublishers();

        if (!payload.GoodResponse)
        {
            return TypedResults.NotFound(payload.Message);
        }

        return TypedResults.Ok(payload.Data);

    } 


    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public static async Task<IResult> GetPublisher(IPublisherRepository publisherRepository, int id)
    {
        Payload<PublisherGetDTO> payload = await publisherRepository.GetPublisher(id);

        if (!payload.GoodResponse)
        {
            return TypedResults.NotFound(payload.Message);
        }

        return TypedResults.Ok(payload.Data);
    }
}
