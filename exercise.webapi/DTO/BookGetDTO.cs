using System.Text.Json.Serialization;

namespace exercise.webapi.DTO
{
    public class BookGetDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        [JsonIgnore]
        public AuthorGetDTO? Author { get; set; }

        public int PublisherId { get; set; }
        [JsonIgnore]
        public PublisherGetDTO? Publisher { get; set; }
    }
}
