using exercise.webapi.Models.DTO;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class PublisherApi
    {
        public static void ConfigurePublisherApi(this WebApplication app)
        {
            var publishers = app.MapGroup("/publishers");

            publishers.MapGet("/", GetPublishers);
            publishers.MapGet("/{id}", GetPublisher);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetPublishers(IPublisherRepository publisherRepository)
        {
            var publishers = await publisherRepository.GetPublishers();
            List<PublisherResponseDTO> result = new List<PublisherResponseDTO>();
            foreach (var publisher in publishers)
            {
                List<BookAuthorResponseDTO> books = new List<BookAuthorResponseDTO>();
                foreach (var book in publisher.Books)
                {
                    books.Add(book.ToTDOAuthorResponse());
                }
                result.Add(publisher.ToDTO(books));
            }
            return TypedResults.Ok(result);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetPublisher(IPublisherRepository publisherRepository, int id)
        {
            var publisher = await publisherRepository.GetPublisher(id);
            if (publisher == null)
            {
                return TypedResults.NotFound($"Publisher with id {id} was not found");
            }
            List<BookAuthorResponseDTO> books = new List<BookAuthorResponseDTO>();
            foreach (var book in publisher.Books)
            {
                books.Add(book.ToTDOAuthorResponse());
            }
            return TypedResults.Ok(publisher.ToDTO(books));
        }


    }
}
