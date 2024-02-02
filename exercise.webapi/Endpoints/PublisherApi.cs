using exercise.webapi.Models;
using exercise.webapi.Models.DatabaseModels;
using exercise.webapi.Models.GenericDto;
using exercise.webapi.Repository;
using static System.Net.Mime.MediaTypeNames;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class PublisherApi
    {
        public static void ConfigurePublisherApi(this WebApplication app)
        {
            var publisherGroup = app.MapGroup("Publisher");

            publisherGroup.MapGet("/", GetPublsihers);
            publisherGroup.MapGet("/{id}", GetAPublisher);
        }

        private static async Task<IResult> GetPublsihers(IPublisherRepository publisherRepository)
        {
            var publishers = await publisherRepository.GetAllPublishers();

            List<PublisherDto> publishersDto = new List<PublisherDto>();

            foreach (var publisher in publishers)
            {
                PublisherDto publisherDto = new PublisherDto()
                {
                    Id = publisher.Id,
                    Name = publisher.Name,
                    Books = new List<BookAuthorDto>()

                };
                foreach (var book in publisher.Books)
                {
                    var bookDto = new BookAuthorDto()
                    {
                        Id = book.Id,
                        Title = book.Title,
                        AuthorId = publisher.Id,
                        Author = new AuthorPlainDto()
                        {
                            Id = book.AuthorId,
                            FirstName = book.Author.FirstName,
                            LastName = book.Author.LastName,
                            Email = book.Author.Email
                        }
                    };
                    publisherDto.Books.Add(bookDto);
                }
                publishersDto.Add(publisherDto);
            }

            Payload<List<PublisherDto>> payload = new Payload<List<PublisherDto>>();
            payload.data = publishersDto;
            return TypedResults.Ok(payload);
        }

        private static async Task<IResult> GetAPublisher(IPublisherRepository publisherRepository, int id)
        {
            var publisher = await publisherRepository.GetAPublsiher(id);

            if (publisher == null)
            {
                return TypedResults.BadRequest();
            }

            PublisherDto publisherDto = new PublisherDto()
            {
                Id = publisher.Id,
                Name = publisher.Name,
                Books = new List<BookAuthorDto>()

            };
            foreach (var book in publisher.Books)
            {
                var bookDto = new BookAuthorDto()
                {
                    Id = book.Id,
                    Title = book.Title,
                    AuthorId = publisher.Id,
                    Author = new AuthorPlainDto()
                    {
                        Id = book.AuthorId,
                        FirstName = book.Author.FirstName,
                        LastName = book.Author.LastName,
                        Email = book.Author.Email
                    }
                };
                publisherDto.Books.Add(bookDto);
            }

            Payload<PublisherDto> payload = new Payload<PublisherDto>();
            payload.data = publisherDto;
            return TypedResults.Ok(payload);
        }
    }
}
