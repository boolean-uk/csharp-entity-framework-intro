using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ef.intro.wwwapi.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        [JsonIgnore]
        public Author Author { get; set; }

        [ForeignKey("Publisher")]
        public int PublisherId { get; set; }
        [JsonIgnore]
        public Publisher Publisher { get; set; }
    }
}