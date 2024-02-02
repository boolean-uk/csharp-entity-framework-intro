using System.Text.Json.Serialization;

namespace exercise.webapi.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore] // Todo: replace this with DTO approach
        public ICollection<Book> books { get; set; } = new List<Book>();
    }
}
