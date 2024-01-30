using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class PublisherDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public PublisherDTO(Publisher publisher) {           
            Id = publisher.Id;
            Name = publisher.Name;
        }

    }
}
