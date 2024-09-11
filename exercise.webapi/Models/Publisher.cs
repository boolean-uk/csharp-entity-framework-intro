using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models
{
    [Table("publishers")]
    public class Publisher
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }

        public ICollection<Book> Published { get; set; } = new List<Book>();
    }
}
