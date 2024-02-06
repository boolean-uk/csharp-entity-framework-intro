using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models
{
    [Table("publishers")]
    public class Publisher
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
