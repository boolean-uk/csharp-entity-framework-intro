using exercise.webapi.Models;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class PublisherAPI
    {
        public static void ConfigurePublisherApi(this WebApplication app)
        {
            var publishers = app.MapGroup("publishers/");
            publishers.MapGet("/", GetAllPublishers);
            publishers.MapGet("/{id}", GetPublisherById);

        }

        private static async Task<IResult> GetAllPublishers(IPublisherRepository publisherRepo)
        {
            var publishers = from publisher in await publisherRepo.GetAllPublishers()
                             select new PublisherDTO()
                             {
                                 Id = publisher.Id,
                                 Name = publisher.Name,
                                 Books = publisher.Books.Select(book => new BookDTO()
                                 {
                                     Id = book.Id,
                                     Title = book.Title,
                                     authorId = book.AuthorId,
                                     AuthorName = $"{book.Author.FirstName} {book.Author.LastName}",
                                     PublisherId = publisher.Id,
                                     PublisherName = publisher.Name,
                                 })

                             };

            return TypedResults.Ok(publishers);
        }

        private static async Task<IResult> GetPublisherById(IPublisherRepository publisherRepo, int id)
        {
            var publisher = await publisherRepo.GetPublisher(id);
            var publisherDTO = new PublisherDTO()
            {
                Id = publisher.Id,
                Name = publisher.Name,
                Books = publisher.Books.Select(book => new BookDTO()
                {
                    Id = book.Id,
                    Title = book.Title,
                    authorId = book.AuthorId,
                    AuthorName = $"{book.Author.FirstName} {book.Author.LastName}",
                    PublisherId = publisher.Id,
                    PublisherName = publisher.Name,
                })
            };
            return TypedResults.Ok(publisherDTO);
        }
    }
}
