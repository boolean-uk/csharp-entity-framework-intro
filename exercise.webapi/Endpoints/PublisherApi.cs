using exercise.webapi.DTO_s;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace exercise.webapi.Endpoints
{
    public static class PublisherApi
    {
        public static void ConfigurePublisherApi(this WebApplication app)
        {
            var publisherGRoup = app.MapGroup("Publishers");

            publisherGRoup.MapGet("", GetPublishers);
            publisherGRoup.MapGet("/{id}", GetAPublisher);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetPublishers(IPublisherRepository publisherRepository, IBookRepository bookRep)
        {
            var publishers = await publisherRepository.GetPublishers();
            var books = await bookRep.GetAllBooks();

            List<PublisherDto> allPublishers = new List<PublisherDto>();

            foreach (var entity in publishers)
            {
                var publisherDto = new PublisherDto
                {
                    Id = entity.Id,
                    Name = entity.Name,
                    Books = books
                        .Where(book => book.PublisherId == entity.Id)
                        .Select(book => new BookDTO
                        {
                            Id = book.Id,
                            Title = book.Title,
                            AuthorFirstName = book.Author.FirstName,
                            AuthorLastName = book.Author.LastName,
                            PublisherId = book.PublisherId
                        })
                        .ToList()
                };

                allPublishers.Add(publisherDto);
            }

            return TypedResults.Ok(allPublishers);
        }


        [ProducesResponseType(StatusCodes.Status200OK)]

         public static async Task<IResult> GetAPublisher(IPublisherRepository publisherRepository, IBookRepository bookRep, int id)
        {
            var publisher = await publisherRepository.GetAPublisher(id);
            var books = await bookRep.GetAllBooks();

            var publisherDto = new PublisherDto
            {
                Id = publisher.Id,
                Name = publisher.Name,
                Books = books
                        .Where(book => book.PublisherId == publisher.Id)
                        .Select(book => new BookDTO
                        {
                            Title = book.Title,
                            AuthorFirstName = book.Author.FirstName,
                            AuthorLastName = book.Author.LastName,
                            PublisherId = book.PublisherId
                        })
                        .ToList()
            };

            return TypedResults.Ok(publisherDto);
        }
    }
}
