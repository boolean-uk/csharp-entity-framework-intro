using System.Text.Json.Serialization;

namespace exercise.webapi.DTO
{
    public class BookGetDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [JsonIgnore]
        public int AuthorId { get; set; }
        public AuthorGetDTO? Author { get; set; }

        [JsonIgnore]
        public int PublisherId { get; set; }

        public PublisherGetDTO? Publisher { get; set; }
    }
}
