using exercise.webapi.Repository;
using exercise.webapi.DTO;

namespace exercise.webapi.Endpoints
{
    public static class PublisherApi
    {
        public static void ConfigurePublisherApi(this WebApplication app)
        {
            var publisherGroup = app.MapGroup("/publisher");
            publisherGroup.MapGet("/", GetAllPublishers);
        }



        private static async Task<IResult> GetAllPublishers(IPublisherRepository publisherRepository)
        {

            return TypedResults.Ok(PublisherResponseDTO.FromRepository(await publisherRepository.GetAllPublishers()));
        }
    }


}
