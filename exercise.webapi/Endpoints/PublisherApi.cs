using exercise.webapi.DTO;
using exercise.webapi.DTOS;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class PublisherApi
    {
        public static void ConfigurePublisherApi(this WebApplication app)
        {
            var authors = app.MapGroup("publishers");

            authors.MapGet("/", GetPublishers);
            authors.MapGet("/{id}", GetPublisherById);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetPublishers(IPublisherRepository publisherRepository)
        {
            GetAllPublishersResponse response = new GetAllPublishersResponse();
            var publishers = await publisherRepository.GetAllPublishers();

            foreach (Publisher publisher in publishers)
            {
                DTOPublisherWithBook dtoPublisher = new DTOPublisherWithBook()
                {
                    Id = publisher.Id,
                    Name = publisher.Name,
                    Email = publisher.Email
                };

                foreach (Book book in publisher.Books)
                {
                    DTOBookWithAuthor dtoBook = new DTOBookWithAuthor()
                    {
                        Id = book.Id,
                        Title = book.Title,
                    };

                    if (book.Author != null) 
                    {
                        DTOAuthorWithoutBooks dtoAuthor = new DTOAuthorWithoutBooks()
                        {
                            Id = book.Author.Id,
                            FirstName = book.Author.FirstName,
                            LastName = book.Author.LastName,
                            Email = book.Author.Email
                        };

                        dtoBook.Author = dtoAuthor;
                    }
                    
                    dtoPublisher.Books.Add(dtoBook);
                }

                response.Publishers.Add(dtoPublisher);
            }

            return TypedResults.Ok(response.Publishers);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetPublisherById(IPublisherRepository publisherRepository, int id)
        {
            try
            {
                var publisher = await publisherRepository.GetPublisherById(id);

                DTOPublisherWithBook dtoPublisher = new DTOPublisherWithBook() 
                {
                    Id = publisher.Id,
                    Name = publisher.Name,
                    Email = publisher.Email,
                };

                foreach (Book book in publisher.Books) 
                {
                    DTOAuthorWithoutBooks dtoAuthor = new DTOAuthorWithoutBooks() 
                    {
                        Id = book.Author.Id,
                        FirstName = book.Author.FirstName,
                        LastName = book.Author.LastName,
                        Email = book.Author.Email
                    };

                    DTOBookWithAuthor dtoBook = new DTOBookWithAuthor()
                    {
                        Id = book.Id,
                        Title = book.Title,
                        Author = dtoAuthor
                    };

                    dtoPublisher.Books.Add(dtoBook);
                }

                return TypedResults.Ok(dtoPublisher);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
