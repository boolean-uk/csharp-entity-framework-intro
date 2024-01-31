using exercise.webapi.Models;

namespace exercise.webapi.DTO.PublisherDTO
{
    public class PublisherDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<BookPublisherDTO> Books { get; set; } = new List<BookPublisherDTO>();

        public PublisherDTO(Publisher publisher)
        {
            Id = publisher.Id;
            Name = publisher.Name;
            foreach (var book in publisher.Books)
            {
                Books.Add(new BookPublisherDTO(book));
            }
        }

        public static List<PublisherDTO> FromRepository(IEnumerable<Publisher> publishers)
        {
            var result = new List<PublisherDTO>();
            foreach (var publisher in publishers)
            {
                result.Add(new PublisherDTO(publisher));
            }
            return result;
        }
    }
}
