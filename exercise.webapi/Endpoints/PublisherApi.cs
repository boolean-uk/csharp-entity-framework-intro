using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class PublisherApi
    {
        public static void ConfigurePublisherApi(this WebApplication app)
        {
            var books = app.MapGroup("publishers");
            books.MapGet("/", GetAllPublishers);
            books.MapGet("/{id}", GetAPublisher);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAllPublishers(IPublisherRepository publisherRepository)
        {
            var publisherClasses = await publisherRepository.GetAllPublishers();

            List<PublisherResponseDTO> publisherDTOs = new List<PublisherResponseDTO>();

            foreach (var publisherClass in publisherClasses)
            {
                var publisherDTO = new PublisherResponseDTO
                {
                    Id = publisherClass.Id,
                    Name = publisherClass.Name,
                    PublishedBooks = publisherClass.PublishedBooks.Select(b => new BookResponseDTO
                    {
                        Id = b.Id,
                        Title = b.Title,

                        //Do I need to create a thrird BookDTO to remove this? I mean, this information is redundant
                        //There are starting to be a lot of DTOs now and my code duplication sense is tingling that I'm doing something wrong in regards to how I manage the DTOs
                        //Right now my understanding of DTO is that you have to have one in the bottom that stops the recursions, let's call it level 1. I have made level 2 DTOs(with Response suffix)
                        //This call(GetAllPublishers) is a level 2 DTO which uses another level 2 DTO(PublisherResponseDTO) and that DTO stores a level 1 DTO of the Publisher. 
                        //I'm starting to feel that I have misunderstood DTOs and what they are supposed to do.
                        PublisherId = b.PublisherId,
                        Publisher = new PublisherDTO
                        {
                            Name = b.Publisher.Name
                        },

                        AuthorId = b.AuthorId,
                        Author = new AuthorDTO
                        {
                            FirstName = b.Author.FirstName,
                            LastName = b.Author.LastName,
                            Email = b.Author.Email
                        }
                    }).ToList()
                };
                publisherDTOs.Add(publisherDTO);
            }

            return TypedResults.Ok(publisherDTOs);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAPublisher(IPublisherRepository publisherRepository, int id)
        {
            var publisherClass = await publisherRepository.GetAPublisher(id);
            
            var publisherDTO = new PublisherResponseDTO
            {
                Id = publisherClass.Id,
                Name = publisherClass.Name,
                PublishedBooks = publisherClass.PublishedBooks.Select(b => new BookResponseDTO
                {
                    Id = b.Id,
                    Title = b.Title,
                    PublisherId = b.PublisherId,
                    Publisher = new PublisherDTO
                    {
                        Name = b.Publisher.Name
                    },
                    AuthorId = b.AuthorId,
                    Author = new AuthorDTO
                    {
                        FirstName = b.Author.FirstName,
                        LastName = b.Author.LastName,
                        Email = b.Author.Email
                    }
                }).ToList()
            };
          
            return TypedResults.Ok(publisherDTO);
        }
    }
}
