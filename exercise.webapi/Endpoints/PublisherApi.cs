using exercise.webapi.AlternativeModels;
using exercise.webapi.Conversions;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class PublisherApi
    {
        public static void ConfigurePublishersApi(this WebApplication app)
        {

            var publishers = app.MapGroup("/publisher");

            publishers.MapGet("/", GetPublishers);
            publishers.MapGet("/{id}", GetPublisher);
        }
        private static async Task<IResult> GetPublishers(IPublisherRepository publisherRepository)
        {
            var publishers = await publisherRepository.GetPublishers();

            List<APublisherDto> result = PublisherConversion.toPublisher(publishers);

            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetPublisher(IPublisherRepository publisherRepository, int id)
        {
            var publisher = await publisherRepository.GetPublisher(id);
            if (publisher == null) return TypedResults.NotFound("id not found");

            APublisherDto publisherDto = PublisherConversion.toPublisher(publisher);

            return TypedResults.Ok(publisherDto);
        }
    }
}
