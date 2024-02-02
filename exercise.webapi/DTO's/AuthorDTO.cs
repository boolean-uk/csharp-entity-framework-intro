using exercise.webapi.Models;
using System.Text.Json.Serialization;

namespace exercise.webapi.DTO_s
{
    public class AuthorDTO
    {
        public int Id { get; internal set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
