using exercise.webapi.Models;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class PublisherApi
    {
        public static void ConfigurePublisherApi(this WebApplication app)
        {
            app.MapGet("/publisher", GetPublisher);
            app.MapGet("/publisher/{id}", GetPublisherById);
        }
        private static async Task<IResult> GetPublisher(IPublisherRepository publisherRepository)
        {
            var publishers = await publisherRepository.GetAllPublishers();
            var results = new List<PublisherResponseDTO>();
            foreach (var pub in publishers)
            {
                results.Add(new PublisherResponseDTO(pub));
            }
            return TypedResults.Ok(results);
        }
        private static async Task<IResult> GetPublisherById(IPublisherRepository publisherRepository, int id)
        {
            var publisher = await publisherRepository.GetPublisherbyID(id);
            if (publisher is null) return TypedResults.NotFound();
            PublisherResponseDTO result = new PublisherResponseDTO(publisher);
            return TypedResults.Ok(result);
        }

    }
}
