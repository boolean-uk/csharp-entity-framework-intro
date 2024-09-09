using exercise.webapi.Models;
using exercise.webapi.Repository;
using System.Runtime.CompilerServices;

namespace exercise.webapi.Endpoints
{
    public static class PublisherApi
    {
        public static void ConfigurePublisherApi(this WebApplication app)
        {
            var publishers = app.MapGroup("publishers");
            publishers.MapGet("/", GetAll);
            publishers.MapGet("/{id}", GetPublisher);
        }

        private static async Task<IResult> GetPublisher(IPublisherRepository repository, int id)
        {
            var publisher = repository.GetPublisher(id);

            return TypedResults.Ok(publisher);

        }

        private static async Task<IResult> GetAll(IPublisherRepository repository)
        {
            var publishers = repository.GetAll();

            return TypedResults.Ok(publishers);
        }
    }
}
