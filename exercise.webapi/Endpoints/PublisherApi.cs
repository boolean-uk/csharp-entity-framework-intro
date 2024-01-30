
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
            app.MapGet("/publisher/{publisherId}", GetPublishersById);
            //app.MapPost("/{Id}", UpdateBook);
            //app.MapDelete("/{Id}", DeleteBook);
        }

        private static async Task<IResult> GetPublishers(IPublisherRepository publisherRepository)
        {
            var publishers = PublisherDTO.FromRepository(await publisherRepository.GetAllPublishers());
            return TypedResults.Ok(publishers);
        }

        private static async Task<IResult> GetPublishersById(IPublisherRepository publisherRepository, int Id)
        {
            var publishers = new PublisherBookAuthorDTO(await publisherRepository.GetPublisherById(Id));
            return TypedResults.Ok(publishers);
        }

    }
}