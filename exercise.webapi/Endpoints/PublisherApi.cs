
using exercise.webapi.DtoModels.PublisherDtos;
using exercise.webapi.Models;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class PublisherApi
    {
        public static void ConfigurePublishersApi(this WebApplication app)
        {
            app.MapGet("/publishers", GetPublishers);
            app.MapGet("/publishers/{id:int}", GetSinglePublisher);

        }

        private static async Task<IResult> GetSinglePublisher(IPublisherRepository repo, int id)
        {
            var publisher = await repo.GetSinglePublisher(id);
            if(publisher == null)
            {
                TypedResults.NotFound("Publisher does not exist");
            }
            PublisherDto publisherDto = new PublisherDto(publisher);
            return TypedResults.Ok(publisherDto);
        }

        private static async Task<IResult> GetPublishers(IPublisherRepository repo)
        {
            var publishers = await repo.GetPublishers();
            List<PublisherDto> publisherDtos = new List<PublisherDto>();
            foreach(var p in publishers)
            {
                publisherDtos.Add(new PublisherDto(p));
            }
            return TypedResults.Ok(publisherDtos);
        }
    }
}
