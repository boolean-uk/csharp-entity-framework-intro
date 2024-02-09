using exercise.webapi.DTO;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class PublisherApi
    {
        public static void ConfigurePublishersApi(this WebApplication app)
        {
            app.MapGet("/publishers", GetPublishers);
            app.MapGet("/publisher", GetPublisher);
        }
        private static async Task<IResult> GetPublishers(IPublisherRepository publisherRepository)
        {
            var publisher = GetPublisherDTO.FromRepository(await publisherRepository.GetAllPublishers());
            return TypedResults.Ok(publisher);
        }
        private static async Task<IResult> GetPublisher(IPublisherRepository publisherRepository, int id)
        {
            //Load publisher
            var publisher = await publisherRepository.GetPublisher(id);
            //Check if publisher exists otherwise return notFound
            if (publisher == null)
            {
                return TypedResults.NotFound($"No publisher found with id: {id}!");
            }
            //Insert publisher into DTO and return ok
            var result = new GetPublisherDTO(publisher);
            return TypedResults.Ok(result);
        }
    }
}
