using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class PublisherApi
    {
        public static void ConfigurePublishersApi(this WebApplication app)
        {
            // Map endpoint to get all publishers
            app.MapGet("/publishers", GetAllPublishers);

            // Map endpoint to get a single publisher by id
            app.MapGet("/publishers/{id}", GetPublishersById);

        }

        private static async Task<IResult> GetAllPublishers(IPublisherRepository publisherRepository)
        {
            // Retrieve all publishers using the publisherRepository
            var publishers = from publisher in await publisherRepository.GetAllPublishers()
                select new PublisherDTO()
                {
                    Id = publisher.Id,
                    Name = publisher.Name,
                    Books = publisher.Books.Select(book => new BookDTO()
                    {
                        Id = book.Id,
                        Title = book.Title,
                        AuthorId = book.AuthorId,
                        Author = $"{book.Author.FirstName} {book.Author.LastName}",
                        PublisherId = publisher.Id,
                        Publisher = publisher.Name
                    })
                };
            return TypedResults.Ok(publishers);
        }


        private static async Task<IResult> GetPublishersById(int id, IPublisherRepository publisherRepository)
        {
            var publisher = await publisherRepository.GetPublisher(id);
            var publisherDTO = new PublisherDTO()
            {
                Id = publisher.Id,
                Name = publisher.Name,
                Books = publisher.Books.Select(x => new BookDTO()
                {
                    Id = x.Id,
                    Title = x.Title,
                    AuthorId = x.AuthorId,
                    Author = $"{x.Author.FirstName} {x.Author.LastName}",
                    PublisherId = publisher.Id,
                    Publisher = publisher.Name
                })

            };
            // Return Ok if the publisher is found, NotFound otherwise
            return publisher != null ? TypedResults.Ok(publisherDTO) : TypedResults.NotFound();
        }
    }
}
