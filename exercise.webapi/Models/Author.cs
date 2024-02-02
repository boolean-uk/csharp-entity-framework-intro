using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace exercise.webapi.Models
{
    [Table("author")]
    public class Author
    {
        [Column("id")]
        public int Id { get; internal set; }
        [Column("first_name")]
        public string FirstName { get; set; }
        [Column("last_name")]
        public string LastName { get; set; }
        [Column("email")]
        public string Email { get; set; }

        public ICollection<BookAuthor> Books { get; internal set; } = new List<BookAuthor>();

    }
}
