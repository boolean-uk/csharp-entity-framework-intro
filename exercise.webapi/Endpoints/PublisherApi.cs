using exercise.webapi.DTO;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class PublisherApi
    {
        
        public static void ConfigurePublishersApi(this WebApplication app)
        {
            var publisher = app.MapGroup("publishers");
            publisher.MapGet("/", GetPublishers);
            publisher.MapGet("/{id}", GetPublisher);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetPublisher(IPublisherRepository publisherRepository, int id)
        {
            var publisher = await publisherRepository.GetPublisher(id);
            var result = new PublisherDTO()
            {
                Id = publisher.Id,
                Name = publisher.Name,
                Books = []
            };

            foreach (var b in publisher.Books)
            {
                BookAuthorDTO bookDTO = new BookAuthorDTO()
                {
                    Id = b.Id,
                    Title = b.Title,
                    AuthorName = $"{b.Author.FirstName} {b.Author.LastName}",
                };
                result.Books.Add(bookDTO);
            }

            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetPublishers(IPublisherRepository publisherRepository)
        {
            var publishers = await publisherRepository.GetAllPublishers();
            var result = new List<PublisherDTO>();

            foreach (var p in publishers)
            {
                var publisherDTO = new PublisherDTO()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Books = []
                };

                foreach (var b in p.Books)
                {
                    if (!p.Books.Any()) continue;
                    BookAuthorDTO bookDTO = new BookAuthorDTO()
                    {
                        Id = b.Id,
                        Title = b.Title,
                        AuthorName = $"{b.Author.FirstName} {b.Author.LastName}",
                    };
                    publisherDTO.Books.Add(bookDTO);
                }
                result.Add(publisherDTO);
            }

            return TypedResults.Ok(result);
        }

    }
}

