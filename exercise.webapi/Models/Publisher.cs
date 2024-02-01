using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models
{
    public class Publisher
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }

        [Column("books")]
        public IEnumerable<Book> Books { get; set; }
    }
}
