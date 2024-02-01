using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace exercise.webapi.Models
{
    [Table("author")]
    public class Author
    {
        [Column("id")]
        public int Id { get; set; }
        
        [Column("first_name")]
        public string FirstName { get; set; }
        
        [Column("last_name")]
        public string LastName { get; set; }
        
        [Column("email")]
        public string Email { get; set; }

        [JsonIgnore] // Todo: replace this with DTO approach
        [Column("books")]
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
