using System.ComponentModel.DataAnnotations.Schema;
using exercise.webapi.DTO;

namespace exercise.webapi.Models
{
    public class PublisherResponseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public ICollection<BookDTO> Books { get; set; } = new List<BookDTO>();

        public PublisherResponseDTO(Publisher publisher)
        {
            Id = publisher.Id;
            Name = publisher.Name;
            Email = publisher.Email;
            foreach (var book in publisher.Books)
            {
                Books.Add(new BookDTO(book));
            }
        }

        public static List<PublisherResponseDTO> FromRepository(IEnumerable<Publisher> publishers){
            var results = new List<PublisherResponseDTO>();
            foreach (var book in publishers)
            {
                results.Add(new PublisherResponseDTO(book));
            }
            return results;
        }

        public static PublisherResponseDTO FromRepository(Publisher publisher){
            return new PublisherResponseDTO(publisher);
        }

    }
}
