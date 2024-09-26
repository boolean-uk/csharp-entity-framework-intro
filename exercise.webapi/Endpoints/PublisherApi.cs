
using exercise.webapi.Models.DTOs;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class PublisherApi
    {
        public static void ConfigurePublisherApi(this WebApplication app)
        {
            //app.MapGroup("/publisher");
            //app.MapPost("/", AddBook);
            app.MapGet("/publisher", GetPublishers);
            app.MapGet("/publisher/{publisherId}", GetPublisherById);
            //app.MapPost("/{Id}", UpdateBook);
            //app.MapDelete("/{Id}", DeleteBook);
        }

        private static async Task<IResult> GetPublishers(IPublisherRepository publisherRepository)
        {
            var publishers = PublisherDTO.FromRepository(await publisherRepository.GetAllPublishers());
            return TypedResults.Ok(publishers);
        }

        public static async Task<IResult> GetPublisherById(IPublisherRepository publisherRepository, int publisherId)
        {
        var publisher = await publisherRepository.GetPublisherById(publisherId);
        var publisherDto = new PublisherDTO(publisher);
        return TypedResults.Ok(publisherDto);
        }

    }
}