using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public ICollection<BookAuthor> Books { get; set; } = new List<BookAuthor>();
    }
}
