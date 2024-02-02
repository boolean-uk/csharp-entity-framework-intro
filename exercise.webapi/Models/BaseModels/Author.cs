using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace exercise.webapi.Models.BaseModels
{
    public class Author
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
