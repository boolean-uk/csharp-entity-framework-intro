using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models
{
    [Table("Authors")]
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

        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
