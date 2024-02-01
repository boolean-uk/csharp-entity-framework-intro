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
        }

        private static async Task<IResult> GetPublishers(IPublisherRepository publisherRepository)
        {
            var result = await publisherRepository.GetPublishers();
            List<PublisherDTO> publishers = new List<PublisherDTO>();
            foreach (var publisher in result)
            {
                publishers.Add(new PublisherDTO(publisher));
            }

            return TypedResults.Ok(publishers);
        }
    }
}
