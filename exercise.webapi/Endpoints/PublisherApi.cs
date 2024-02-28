using exercise.webapi.DTO;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class PublisherApi
    {
        public static void ConfigurePublishersApi(this WebApplication app)
        {
            app.MapGet("/publishers", GetPublishers);
            app.MapGet("/publishers/{id}", GetPublisher);
        }

        private static async Task<IResult> GetPublishers(IPublisherRepository publisherRepository)
        {
            var publishers = await publisherRepository.GetAllPublishers();
            return TypedResults.Ok(PublisherResponseDTO.FromRepository(publishers));
        }

        private static async Task<IResult> GetPublisher(IPublisherRepository publisherRepository, int id)
        {
            var publisher = await publisherRepository.GetPublisher(id);
            return TypedResults.Ok(new PublisherResponseDTO(publisher));
        }
    }
}
