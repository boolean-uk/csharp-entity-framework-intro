using exercise.webapi.Models;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class PublisherApi
    {
        public static void ConfigurePublisherApi(this WebApplication app)
        {
            var group = app.MapGroup("publishers");
            group.MapGet("/", GetPublishers);
            group.MapGet("/{id}", GetPublisherById);
        }

        private static async Task<IResult> GetPublishers(IPublisherRepository publisherRepository)
        {
            // Getting dto obj from PublisherRepository (is this more accurate than creating dto here)
            var result = await publisherRepository.GetPublishers();
            return TypedResults.Ok(result);
        }

        private static async Task<IResult> GetPublisherById(IPublisherRepository publisherRepository, int id)
        {
            // Getting dto obj from PublisherRepository
            var result = await publisherRepository.GetPublisher(id);
            return TypedResults.Ok(result);
        }
    }
}
