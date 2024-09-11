using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using exercise.webapi.ViewModels;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class PublisherApi
    {
        public static void ConfigurePublishersApi(this WebApplication app)
        {
            app.MapGet("/publishers", GetPublishers);
            app.MapGet("/publishers{id}", GetOnePublisher);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetPublishers(IPublisherRepository publisherRepository)
        {
            GetAllResponse<DTOPublisher> publisherResponse = new GetAllResponse<DTOPublisher>();
            var publishers = await publisherRepository.GetAllPublishers();

            foreach (Publisher publisher in publishers)
            {
                DTOPublisher dtopublisher = new DTOPublisher() { ID = publisher.Id, Name = publisher.Name };
                foreach (Book book in publisher.Published)
                {
                    DTOAuthorWithoutBooks dtoauthor = new DTOAuthorWithoutBooks() { ID = book.Author.Id, Name = $"{book.Author.FirstName} {book.Author.LastName}" };
                    DTOBookWithoutPublisher dtobook = new DTOBookWithoutPublisher() { ID = book.Id, Title = book.Title, Author = dtoauthor };
                    dtopublisher.published.Add(dtobook);
                }

                publisherResponse.response.Add(dtopublisher);
            }

            return TypedResults.Ok(publisherResponse);
        }

        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetOnePublisher(int id, IPublisherRepository publisherRepository)
        {
            var publisher = await publisherRepository.GetAPublisher(id);

            if (publisher == null)
            {
                return TypedResults.NotFound(new Message());
            }

            DTOPublisher dtopublisher = new DTOPublisher() { ID = publisher.Id, Name = publisher.Name };
            foreach (Book book in publisher.Published)
            {
                DTOAuthorWithoutBooks dtoauthor = new DTOAuthorWithoutBooks() { ID = book.Author.Id, Name = $"{book.Author.FirstName} {book.Author.LastName}" };
                DTOBookWithoutPublisher dtobook = new DTOBookWithoutPublisher() { ID = book.Id, Title = book.Title, Author = dtoauthor };
                dtopublisher.published.Add(dtobook);
            }

            return TypedResults.Ok(dtopublisher);
        }
    }
}