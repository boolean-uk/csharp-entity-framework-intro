using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class PublisherApi
    {
        public static void ConfigurePublishersApi(this WebApplication app)
        {
            var publishers = app.MapGroup("publishers");
            publishers.MapGet("/", GetPublishers);
            publishers.MapGet("/{id}", GetPublisher);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetPublishers(IPublisherRepository publisherRepository)
        {
            var books = await publisherRepository.GetAllPublishers();
            return TypedResults.Ok(books);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetPublisher(IPublisherRepository publisherRepository, int id)
        {
            var book = await publisherRepository.GetPublisher(id);
            return TypedResults.Ok(book);
        }
    }
}
