using System.Text.Json.Serialization;

namespace exercise.webapi.DTO
{
    public class PublisherGetDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<BookGetDTO>? Books { get; set; }
    }
}
