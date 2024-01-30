using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class PublisherPlainDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public PublisherPlainDTO(Publisher p) 
        {
            Id = p.Id;
            Name = p.Name;
        }
    }
}
