using exercise.webapi.DTO;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class PublisherApi
    {
        public static void ConfigurePublisherApi(this WebApplication app)
        {
            var publishers = app.MapGroup("/publishers");
            publishers.MapGet("/", GetPublishers);
            publishers.MapGet("/{id}", GetPublisher);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetPublishers(IPublisherRepository publisherRepository)
        {
            var publishers = await publisherRepository.GetAllPublishers();
            if (publishers.Count() == 0) return TypedResults.NotFound($"No publishers found in the database");
            return TypedResults.Ok(publishers.Select(x => new Publisher_get(x)));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetPublisher(IPublisherRepository publisherRepository, int id)
        {
            var publisher = await publisherRepository.GetPublisher(id);
            if (publisher == null) return TypedResults.NotFound($"No publisher with id[{id}] exists");
            return TypedResults.Ok(new Publisher_get(publisher));
        }
    }
}
