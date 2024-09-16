using System.ComponentModel.DataAnnotations.Schema;
using exercise.webapi.Models.DTO;

namespace exercise.webapi.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }

        public BookDTO ToDTO()
        {
            AuthorDTO authorDTO = Author.ToDTO();
            PublisherDTO publisherDTO = Publisher.ToDTO();
            return new BookDTO { Id = Id, Title = Title, Author = authorDTO, Publisher = publisherDTO };
        }

        public BookResponseDTO ToTDOResponse()
        {
            PublisherDTO publisherDTO = Publisher.ToDTO();
            return new BookResponseDTO { Id = Id, Title = Title, Publisher = publisherDTO };
        }

        public BookAuthorResponseDTO ToTDOAuthorResponse()
        {
            AuthorDTO authorDTO = Author.ToDTO();
            return new BookAuthorResponseDTO { Id = Id, Title = Title, Author = authorDTO };
        }
    }
}
