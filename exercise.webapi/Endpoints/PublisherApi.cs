using exercise.webapi.Models.DatabaseModels;
using exercise.webapi.Models.DataTransfer;
using exercise.webapi.Models.DataTransfer.Books;
using exercise.webapi.Models.DataTransfer.Publishers;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class PublisherApi
    {
        public static void ConfigurePublisherApi(this WebApplication app) 
        {
            var publisherGroup = app.MapGroup("publisher");

            publisherGroup.MapGet("/", GetPublishers);
            publisherGroup.MapGet("/{id}", GetSpecificPublisher);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetPublishers(IRepository<Publisher> repo) 
        {
            var publishers = await repo.GetAll();
            IEnumerable<PublisherDTO> results = publishers
                .ToList()
                .Select(p => new PublisherDTO(p.Id, p.Name)
                {
                    Books = p.Books.Select(b => new BookInPublisherDTO(b.Id, b.Title, b.Author))
                    .ToList()
                });
            Payload<IEnumerable<PublisherDTO>> payload = new Payload<IEnumerable<PublisherDTO>>(results);
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetSpecificPublisher(IRepository<Publisher> repo, int id) 
        {
            var publishers = await repo.Get(id);
            if (publishers == null) 
            {
                return TypedResults.NotFound($"Could not find any publisher with the provided id {id}");
            }
            IEnumerable<BookInPublisherDTO> booksOut = publishers.Books.Select(b => new BookInPublisherDTO(b.Id, b.Title, b.Author));
            PublisherDTO publisherOut = new PublisherDTO(publishers.Id, publishers.Name) { Books = booksOut};

            Payload<PublisherDTO> payload = new Payload<PublisherDTO>(publisherOut);
            return TypedResults.Ok(payload);
        }
    }
}

