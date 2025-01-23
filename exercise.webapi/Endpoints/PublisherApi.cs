using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class PublisherApi
    {
        public static void ConfigurePublishersApi(this WebApplication app)
        {
            var publishers = app.MapGroup("/publishers");

            publishers.MapGet("/", GetPublishers);
            publishers.MapGet("/{id}", GetSinglePublisher);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetPublishers(IPublisherRepository publisherRepository)
        {
            var publishers = await publisherRepository.GetAllPublishers();
            return Results.Ok(publishers);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetSinglePublisher(IPublisherRepository publisherRepository, int id)
        {
            var publisher = await publisherRepository.GetPublisherById(id);
            if (publisher == null)
            {
                return Results.NotFound();
            }
            return Results.Ok(publisher);
        }
    }
}
