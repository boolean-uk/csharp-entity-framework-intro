using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Builder;

namespace exercise.webapi.Endpoints
{
    public static class PublisherApi
    {
        public static void ConfigurePublishersApi(this WebApplication app)
        {
            app.MapGet("/publisher", GetPublishers);
            app.MapGet("/publisher{id}", GetPublisher);
        }

        private static async Task<IResult> GetPublishers(IPublisherRepository publisherRepository)
        {
            var publisher = await publisherRepository.GetAllPublishers();
            return TypedResults.Ok(PublisherResponseDTO.FromRepository(publisher));
        }

        private static async Task<IResult> GetPublisher(IPublisherRepository publisherRepository, int id)
        {
            var publisher = await publisherRepository.GetPublisher(id);
            if (publisher == null)
                return Results.NotFound("Id out of scope");

            return TypedResults.Ok(PublisherResponseDTO.FromARepository(publisher));
        }
    }
}
