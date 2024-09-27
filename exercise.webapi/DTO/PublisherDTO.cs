using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class PublisherDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public PublisherDTO(Publisher publisher)
        {
            Id = publisher.Id;
            Name = publisher.Name;            
        }
    }

    public class PublisherResponseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<BookDto> Books { get; set; } = new List<BookDto>();

        public PublisherResponseDTO(Publisher publisher)
        {
            Id = publisher.Id;
            Name = publisher.Name;
            Books = new List<BookDto>();
            foreach (var book in publisher.Books)
            {
                Books.Add(new BookDto(book));
            }
        }

        public static List<PublisherResponseDTO> FromRepository(IEnumerable<Publisher> publishers)
        {
            var results = new List<PublisherResponseDTO>();
            foreach (var publisher in publishers)
            {
                results.Add(new PublisherResponseDTO(publisher));
            }
            return results;
        }
    }

}