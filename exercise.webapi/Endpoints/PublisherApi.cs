using exercise.webapi.DTO;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class PublisherApi
    {
        public static void ConfigurePublishersApi(this WebApplication app)
        {
            var group = app.MapGroup("publishers");
            app.MapGet("/publishers", GetPublishers);
            app.MapGet("/publishers{id}", GetPublisherById);
        }

        private static async Task<IResult> GetPublishers(IPublisherRepository publisherRepository)
        {
            var publishers = from publisher in await publisherRepository.GetAllPublishers()
                             select new PublisherDto()
                             {
                                 Id = publisher.Id,
                                 PublisherName = publisher.PublisherName,
                                 Books = publisher.Books.Select(book => new BookDto()
                                 {
                                     Id = book.Id,
                                     Title = book.Title,
                                     AuthorId = book.AuthorId,
                                     AuthorName = $"{book.Author.FirstName} {book.Author.LastName}",
                                     PublisherId = publisher.Id,
                                     PublisherName = publisher.PublisherName
                                 })
                             };
            return TypedResults.Ok(publishers);
        }

        private static async Task<IResult> GetPublisherById(IPublisherRepository publisherRepository, int id)
        {
            var publisher = await publisherRepository.GetById(id);
            var publisherDto = new PublisherDto()
            {
                Id = publisher.Id,
                PublisherName = publisher.PublisherName,
                Books = publisher.Books.Select(book => new BookDto()
                {
                    Id = book.Id,
                    Title = book.Title,
                    AuthorId = book.AuthorId,
                    AuthorName = $"{book.Author.FirstName} {book.Author.LastName}",
                    PublisherId = publisher.Id,
                    PublisherName = publisher.PublisherName
                })
            };
            return TypedResults.Ok(publisherDto);
        }
    }
}
