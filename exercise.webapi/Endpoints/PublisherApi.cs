using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class PublisherApi
    {
        public static void ConfigurePublisherApi(this WebApplication app)
        {
            var publisher = app.MapGroup("publishers");
            publisher.MapGet("/publishers", GetAllPublishers);
            publisher.MapGet("/{id:int}", GetPublisherById);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAllPublishers(IPublisherRepository publisherRepository)
        {


            var publishers = await publisherRepository.GetAllPublishers();


            var dtoList = publishers.Select(p => new PublisherDTO
            {
                Name = p.Name,
                Books = p.Books.Select(b => new BookDTO
                {
                    Title = b.Title,
                    AuthorName = $"{b.Author.FirstName} {b.Author.LastName}",
                    AuthorEmail = b.Author.Email,
                    PublisherName = b.Publisher.Name
                }).ToList() 
            }).ToList();

            return TypedResults.Ok(dtoList);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetPublisherById(IPublisherRepository publisherRepository,  int id)
        {
            var publisher = await publisherRepository.GetPublisherById(id);
            if (publisher == null)
            {
                return TypedResults.NotFound();
            }

            var dto = new PublisherDTO
            {
                Name = publisher.Name,
                Books = publisher.Books.Select(b => new BookDTO
                {
                    Title = b.Title,
                    AuthorName = $"{b.Author.FirstName} {b.Author.LastName}",
                    AuthorEmail = b.Author.Email
                }).ToList()
            };

            return TypedResults.Ok(dto);
        }


    }

}
        