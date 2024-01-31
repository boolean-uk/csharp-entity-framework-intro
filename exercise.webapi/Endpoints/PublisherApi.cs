using exercise.webapi.DTO.PublisherDTO;
using exercise.webapi.Repository.PublisherRepo;

namespace exercise.webapi.Endpoints
{
    public static class PublisherApi
    {
        public static void ConfigurePublisherApi(this WebApplication app)
        {
            var publishers = app.MapGroup("/publishers");

            publishers.MapGet("/{id}", GetById);
            publishers.MapGet("", GetAll);

        }

        private static async Task<IResult> GetById(IPublisherRepository publisherRepository, int publisherID)
        {
            var publisher = publisherRepository.GetByIdAsync(publisherID).Result;
            if (publisher == null) { return TypedResults.NotFound($"Publisher id {publisherID} not found"); }

            var result = new PublisherDTO(publisher);
            return TypedResults.Ok(result);
        }

        private static async Task<IResult> GetAll(IPublisherRepository publisherRepository)
        {
            var publisher = PublisherDTO.FromRepository(await publisherRepository.GetAllAsync());
            return publisher == null ? TypedResults.NotFound() : TypedResults.Ok(publisher);
        }
    }
}
