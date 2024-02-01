using exercise.webapi.Models;
using Microsoft.Extensions.Hosting;

namespace exercise.webapi.DTO
{
    public class PublisherResponseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<BookDTO> Books { get; set; } = new List<BookDTO>();

        public PublisherResponseDTO(Publisher publisher)
        {
            Id = publisher.Id;
            Name = publisher.Name;

            Books = new List<BookDTO>();
            foreach (var book in publisher.Books)
                Books.Add(new BookDTO(book));
        }

        public static List<PublisherResponseDTO> FromRepository(IEnumerable<Publisher> publishers)
        {
            var results = new List<PublisherResponseDTO>();
            foreach (var publisher in publishers)
                results.Add(new PublisherResponseDTO(publisher));

            return results;
        }

        public static PublisherResponseDTO FromARepository(Publisher publisher)
        {
            PublisherResponseDTO result = new PublisherResponseDTO(publisher);
            return result;
        }
    }
}
