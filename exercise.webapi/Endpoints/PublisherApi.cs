using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class PublisherApi
    {
        public static void ConfigurePublishersApi(this WebApplication app)
        {
            var group = app.MapGroup("publishers");
            group.MapGet("/", GetPublishers);
            group.MapGet("/{id}", GetPublisher);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetPublishers(IPublisherRepository publisherRepository)
        {
            IEnumerable<Publisher> publishers = await publisherRepository.GetAll();
            List<PublisherDto> publisherDtos = publishers.Select(p => p.ToDto()).ToList();
            return TypedResults.Ok(publisherDtos);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetPublisher(IPublisherRepository publisherRepository, int id)
        {
            var publisher = await publisherRepository.Get(id);
            return publisher == null ? TypedResults.NotFound() : TypedResults.Ok(publisher.ToDto());
        }
    }
}
