using exercise.webapi.Models;
using exercise.webapi.Models.DTO;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class PublisherApi
    {
        public static void ConfigurePublisherApi(this WebApplication app)
        {
            var group = app.MapGroup("publishers");
            group.MapGet("/", GetAll);
            group.MapGet("/{id}", Get);
        }

        private static async Task<IResult> GetAll(IPublisherRepository publisherRepository)
        {
            var publishers = await publisherRepository.Get();

            if (publishers == null)
                return Results.NotFound();

            IEnumerable<OutputPublisher> outputPublishers = Services.DtoManager.Convert(publishers);
            return TypedResults.Ok(outputPublishers);
        }

        private static async Task<IResult> Get(IPublisherRepository publisherRepository, int id)
        {
            Publisher? publisher = await publisherRepository.Get(id);

            if (publisher == null)
                return Results.NotFound();

            OutputPublisher outputPublisher = Services.DtoManager.Convert(publisher);
            return TypedResults.Ok(outputPublisher);
        }
    }
}
