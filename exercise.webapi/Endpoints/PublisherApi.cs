using exercise.webapi.DTOs;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace exercise.webapi.Endpoints
{
    public static class PublisherApi
    {
        public static void ConfigurePublisherAPI(this WebApplication app)
        {
            var books = app.MapGroup("publishers");
            books.MapGet("/", GetPublishers);
            books.MapGet("/{id}", GetAPublisher);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetPublishers(IPublisherRepo publisherrepo)
        {
            var results = await publisherrepo.GetPublishers();
            List<PublisherResponseDTO> publisherDTOs = new List<PublisherResponseDTO>();

            foreach(var publisher in results)
            {
                var publisherDTO = new PublisherResponseDTO
                {
                    Id = publisher.Id,
                    Name = publisher.Name,
                    PublishedBooks = publisher.Publishedbooks.Select(b => new BookResponseDTO
                    {
                        Id = b.Id,
                        Title = b.Title,
                        PublisherId = b.Id,
                        Publisher = new PublisherDTO
                        {
                            Name = publisher.Name
                        },
                        Authors = b.Bookauthors.Select(ba => new AuthorDTO
                        {
                            FirstName = ba.Author.FirstName,
                            LastName = ba.Author.LastName,
                            Email = ba.Author.Email
                        }).ToList()
                    }).ToList()

                };
                publisherDTOs.Add(publisherDTO);
            }
            return TypedResults.Ok(publisherDTOs);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAPublisher(IPublisherRepo publisherrepo, int id)
        {
            var results = await publisherrepo.GetAPublisher(id);

            var publisherDTO = new PublisherResponseDTO
            {
                Id = results.Id,
                Name = results.Name,
                PublishedBooks = results.Publishedbooks.Select(b => new BookResponseDTO
                {
                    Id = b.Id,
                    Title = b.Title,
                    PublisherId = b.PublisherId,
                    Publisher = new PublisherDTO
                    {
                        Name = b.Publisher.Name
                    },
                    Authors = b.Bookauthors.Select(ba => new AuthorDTO
                    {
                        FirstName = ba.Author.FirstName,
                        LastName = ba.Author.LastName,
                        Email = ba.Author.Email
                    }).ToList()
                }).ToList()
            };

            return TypedResults.Ok(publisherDTO);
        }
    }
}
