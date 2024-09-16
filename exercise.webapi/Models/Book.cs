using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace exercise.webapi.Models
{
    public class Book
    {
        public int Id { get; internal set; }
        public string Title { get; set; }
        
        public int AuthorId { get; set; }
        [JsonIgnore]
        public Author Author { get; internal set; }
        [JsonIgnore]
        public int PublisherId { get; set; }
        [JsonIgnore]
        public Publisher Publisher { get; set; }
    }
}
