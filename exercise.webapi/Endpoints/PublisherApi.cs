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
            var pubGroup = app.MapGroup("publisher");
            pubGroup.MapGet("/", GetPublishers);
            pubGroup.MapGet("/{id}", GetAPublisher);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> GetPublishers(IPublisherRepository publisherRepository)
        {
            try
            {
                //Source
                var orginal = await publisherRepository.getPublisher();
                //Target:
                List<PublisherDTO> publishers = new List<PublisherDTO>();
                //Transferring:
                foreach (Publisher entity in orginal)
                {
                    PublisherDTO publisherDTO = new PublisherDTO();
                    {
                        publisherDTO.Id = entity.Id;
                        publisherDTO.Name = entity.Name;
                        //publisherDTO.Books = entity.Books;
                        publisherDTO.Books = entity.Books.Select(b => new BookforAuthorDTO()
                        {
                            Id = b.Id,
                            Title = b.Title,

                            // IMPORTANT!! THIS is to avoid cyclic reference -> need to create new authorDTO
                            Author = new AuthorDTO()
                            {
                                FirstName = b.Author.FirstName,
                                LastName = b.Author.LastName,
                                Email = b.Author.Email

                            }
                        }).ToList();

                    };


                    // Trnsfer books to BookDTO3 -> add to publishers.
                    /* foreach (Book b in entity.Books)
                      {
                          BookDTO3 bookdto = new BookDTO3() { Id = b.Id, Title = b.Title, Author = b.Author };
                          publisherDTO.Books.Add(bookdto);
                      }
  */

                    publishers.Add(publisherDTO);

                }
                return TypedResults.Ok(publishers);
            }

            catch (Exception ex) { return TypedResults.BadRequest("invalid"); }

        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetAPublisher(IPublisherRepository publisherRepository, int? id)
        {
            try
            {
                //Source:
                var original = await publisherRepository.GetAPublisher(id);
                //Target and transferring:
                PublisherDTO publisherDTO = new PublisherDTO();
                {
                    publisherDTO.Id = original.Id;
                    publisherDTO.Name = original.Name;
                    publisherDTO.Books = original.Books.Select(b => new BookforAuthorDTO()
                    {
                        Id = b.Id,
                        Title = b.Title,

                        // IMPORTANT!! THIS is to avoid cyclic reference -> need to create new authorDTO
                        Author = new AuthorDTO()
                        {
                            FirstName = b.Author.FirstName,
                            LastName = b.Author.LastName,
                            Email = b.Author.Email

                        }
                    }).ToList();



                };

                return TypedResults.Ok(publisherDTO);


            }

            catch (BadHttpRequestException ex) { return TypedResults.BadRequest(ex.Message); }
            catch (Exception ex) { return TypedResults.NotFound(ex.Message); }

        }

    }




}
