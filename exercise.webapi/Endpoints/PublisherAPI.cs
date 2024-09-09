using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class PublisherAPI
    {
        public static void ConfigurePublisherEndpoints(this WebApplication app)
        {
            var publishers = app.MapGroup("publishers");
            publishers.MapGet("/", GetAllPublishers);
            publishers.MapGet("/{id}", GetAPublisher);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllPublishers(IPublisherRepository publisherRepository)
        {
            GetPublisherResponse response = new GetPublisherResponse();
            var publishers = await publisherRepository.GetAllPublishers();

            foreach (var publisher in publishers)
            {
                PublisherDTO pubDTO = new PublisherDTO()
                {
                    Id = publisher.Id,
                    Name = publisher.FirstName + " " + publisher.LastName,



                };

                foreach (Book b in publisher.Books)
                {
                    AuthorWithoutEmailBooks author = new AuthorWithoutEmailBooks()
                    {
                        Id = b.Author.Id,
                        Name = b.Author.FirstName + " " + b.Author.LastName,
                    };


                    BookDTO bookDTO = new BookDTO()
                    {
                        Title = b.Title,
                        Id = b.Id,
                        AuthorId = b.AuthorId,
                        Author = author
                    };

                    pubDTO.Books.Add(bookDTO);
                }



                response.Publishers.Add(pubDTO);
            }

            return TypedResults.Ok(response.Publishers);

        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAPublisher(IPublisherRepository publisherRepository, int id)
        {

            var publisher = await publisherRepository.GetPublisher(id);
            PublisherDTO pubDTO = new PublisherDTO();

            pubDTO.Id = publisher.Id;
            pubDTO.Name = publisher.FirstName + " " + publisher.LastName;

            foreach (Book b in publisher.Books)
            {
                AuthorWithoutEmailBooks author = new AuthorWithoutEmailBooks()
                {
                    Id = b.Author.Id,
                    Name = b.Author.FirstName + " " + b.Author.LastName,
                };


                BookDTO bookDTO = new BookDTO()
                {
                    Title = b.Title,
                    Id = b.Id,
                    AuthorId = b.AuthorId,
                    Author = author
                };

                pubDTO.Books.Add(bookDTO);

            }

            


            return TypedResults.Ok(pubDTO);
        }
        

    }
}
