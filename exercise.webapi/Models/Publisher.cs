using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace exercise.webapi.Models
{
    [Table("publishers")]
    public class Publisher
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("email")]
        public string Email { get; set; }

        // [JsonIgnore] // Todo: replace this with DTO approach
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
