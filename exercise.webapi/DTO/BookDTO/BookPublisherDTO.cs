using exercise.webapi.Models;

namespace exercise.webapi.DTO.BookDTO
{
    public class BookPublisherDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public BookPublisherDTO(Publisher publisher)
        {
            Id = publisher.Id;
            Name = publisher.Name;
        }

    }
}
