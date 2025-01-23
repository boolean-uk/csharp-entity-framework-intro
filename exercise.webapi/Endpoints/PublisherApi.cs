using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class PublisherApi
    {
        public static void ConfigurePublishersApi(this WebApplication app)
        {
            var publishers = app.MapGroup("publishers");
            publishers.MapGet("/{id}", GetPublisher);
            publishers.MapGet("/", GetPublishers);
        }


        private static async Task<IResult> GetPublisher(IPublisherRepository publisherRepository, int id)
        {
            var publisher = await publisherRepository.GetPublisher(id);
            if (publisher == null)
            {
                return Results.NotFound();
            }
            return TypedResults.Ok(publisher.Name);
        }


        private static async Task<IResult> GetPublishers(IPublisherRepository publisherRepository)
        {
            var publishers = await publisherRepository.GetPublishers();
            var publisherNames = publishers.Select(publisher => (publisher.Name));
            return TypedResults.Ok(publisherNames);
        }
    }
}
