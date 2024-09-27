using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class PublisherApi
    {
        public static void ConfigurePublishersApi(this WebApplication app)
        {
            var publisherGroup = app.MapGroup("publishers");
            publisherGroup.MapGet("", GetPublishers);
            publisherGroup.MapGet("{id}", GetPublisher);
        }

        private static async Task<IResult> GetPublishers(IPublisherRepository publisherRepository)
        {
            return TypedResults.Ok(await publisherRepository.GetAllPublishers());
        }

        private static async Task<IResult> GetPublisher(IPublisherRepository publisherRepository, int id)
        {
            return TypedResults.Ok(await publisherRepository.GetPublisher(id));
        }
    }
}
