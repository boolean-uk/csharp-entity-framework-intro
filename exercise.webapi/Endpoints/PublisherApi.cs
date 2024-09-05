using exercise.webapi.Data;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using static System.Reflection.Metadata.BlobBuilder;
namespace exercise.webapi.Endpoints
{
    public static class PublisherApi
    {
        public static void ConfigurePublisherApi(this WebApplication app)
        {
            app.MapGet("/publishers/GetAllPublishers", GetAllPublishers);
            app.MapGet("/publishers/getAPublisher{id}", GetPublisher);
        }


        private static async Task<IResult> GetAllPublishers(IPublisherRepository PublisherRepository)
        {
            var publishers = await PublisherRepository.GetAllPublishers();
            return TypedResults.Ok(publishers);
        }

        private static async Task<IResult> GetPublisher(IPublisherRepository publisherRepository, int id)
        {
            var publisher = await publisherRepository.GetPublisher(id);
            return TypedResults.Ok(publisher);
        }
    }
}
