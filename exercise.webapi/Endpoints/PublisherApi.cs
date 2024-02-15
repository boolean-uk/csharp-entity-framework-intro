using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class PublisherApi
    {
        public static void ConfigurePublishersApi(this WebApplication app)
        {
            app.MapGet("/publishers", GetPublishers);
            app.MapGet("/publishers/{id}", GetPublisherById);
        }

        private static async Task<IResult> GetPublishers(IBookRepository bookRepository)
        {
            var publishers = await bookRepository.GetAllPublishers();
            var publisherResponseDTOs = publishers.Select(MapToPublisherResponseDTO).ToList();
            return TypedResults.Ok(publisherResponseDTOs);
        }

        private static async Task<IResult> GetPublisherById(IBookRepository bookRepository, int id)
        {
            var publisher = await bookRepository.GetPublisherById(id);
            if (publisher == null)
                return Results.NotFound();

            var publisherResponseDTO = MapToPublisherResponseDTO(publisher);
            return TypedResults.Ok(publisherResponseDTO);
        }

        private static PublisherResponseDTO MapToPublisherResponseDTO(Publisher publisher)
        {
            return new PublisherResponseDTO
            {
                Id = publisher.Id,
                Name = publisher.Name
            };
        }
    }
}