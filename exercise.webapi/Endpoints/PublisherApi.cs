using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class PublisherApi
    {
        public static void ConfigurePublisherApi(this WebApplication app)
        {
            app.MapGet("/publishers", GetPublishers);
            app.MapGet("/publishers/{id}", GetPublisherbyId);
        }

        private static async Task<IResult> GetPublisherbyId(int id, IPublisherRepository publisherRepository)
        {
            var publisher = await publisherRepository.GetPublisherById(id);
            if (publisher == null) { return TypedResults.NotFound("Publisher not found"); }
            return TypedResults.Ok(publisher);
        }

        private static async Task<IResult> GetPublishers(IPublisherRepository publisherRepository)
        {
            var publishers = await publisherRepository.GetAllPublishers();
            return TypedResults.Ok(publishers);
        }
}
}
