using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace exercise.webapi.Models
{
    [Table("publishers")]
    public class Publisher
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("publisher_na e")]
        public string PublisherName { get; set; }
        [JsonIgnore]
        [Column("books")]
        public ICollection<Book> Books { get; set; }
    }
}
