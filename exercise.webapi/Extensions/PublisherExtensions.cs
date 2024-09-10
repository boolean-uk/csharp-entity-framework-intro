using exercise.webapi.DTOs;
using exercise.webapi.Models;

namespace exercise.webapi.Extensions
{
    public static class PublisherExtensions
    {

        public static PublisherDTO MapToPublisherDTO(this Publisher publisher)
        {
            PublisherDTO publisherDTO = new() 
            {
                Id = publisher.Id,
                Name = publisher.Name 
            };
            publisherDTO.Books = (from book in publisher.Books select book.MapToBookAuthorDTO()).ToList();

            return publisherDTO;
        }
    }
}
