using System.Text.Json.Serialization;

namespace exercise.webapi.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
