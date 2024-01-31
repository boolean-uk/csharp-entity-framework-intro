using exercise.webapi.Models;
using exercise.webapi.Repository;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class PublisherApi
    {
        public static void ConfigurePublisherApi(this WebApplication app)
        {
            app.MapGet("/Publisher", GetPublishers);
            app.MapGet("/GetAPublisher/{id}", GetAPublisher);
        }

        private static async Task<IResult> GetPublishers(IPublisherRepository publisherRepository)
        {
            return TypedResults.Ok(PublisherResponseDTO.FromRepository(await publisherRepository.GetAllPublishers()));
        }

        private static async Task<IResult> GetAPublisher(IPublisherRepository publisherRepository, int authorId)
        {
            return TypedResults.Ok(PublisherResponseDTO.FromRepository(await publisherRepository.GetAPublisher(authorId)));
        }
    }
}