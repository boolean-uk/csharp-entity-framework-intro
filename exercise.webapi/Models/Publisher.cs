using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public ICollection<Book> Books { get; set; } = [];
    }
}
