using exercise.webapi.DTOs;
using exercise.webapi.Extensions;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class PublisherApi
    {
        public static void ConfigurePublisherAPI(this WebApplication app)
        {
            var publishers = app.MapGroup("publishers");
            publishers.MapGet("/", GetAll);
            publishers.MapGet("/{id}", GetA);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetAll(IPublisherRepository repository)
        {
            var publishers = await repository.GetAll();
            if (!publishers.Any()) return TypedResults.NotFound("There are no publishers stored");

            var publishersDTO = (from publisher in publishers select publisher.MapToPublisherDTO()).ToList();

            return TypedResults.Ok(publishersDTO);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetA(IPublisherRepository repository, int id)
        {
            var publisher = await repository.GetA(id);
            if (publisher is null) return TypedResults.NotFound("No such publisher exists");

            

            return TypedResults.Ok(publisher.MapToPublisherDTO());
        }
    }
}
