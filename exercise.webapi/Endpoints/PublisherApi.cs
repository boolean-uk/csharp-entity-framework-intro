using exercise.webapi.Repository;
using exercise.webapi.DTO;
using exercise.webapi.Models;

namespace exercise.webapi.Endpoints
{
    public static class PublisherApi
    {
        public static void ConfigurePublisherApi(this WebApplication app)
        {
            var publisherGroup = app.MapGroup("/publisher");
            publisherGroup.MapGet("/", GetAllPublishers);
            publisherGroup.MapGet("/{id}", GetPublisherById);
        }



        private static async Task<IResult> GetAllPublishers(IPublisherRepository publisherRepository)
        {
            return TypedResults.Ok(PublisherResponseDTO.FromRepository(await publisherRepository.GetAllPublishers()));
        }

        private static async Task<IResult> GetPublisherById(int id, IPublisherRepository publisherRepository)
        {
            Publisher? publisher = await publisherRepository.GetPublisherById(id);
            if (publisher == null)
            {
                return TypedResults.NotFound($"Publisher id {id} could not be found");
            }
            return TypedResults.Ok(new PublisherResponseDTO(publisher));
        }
    }


}
