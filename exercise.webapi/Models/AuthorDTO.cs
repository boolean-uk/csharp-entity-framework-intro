using System.Text.Json.Serialization;

namespace exercise.webapi.Models
{
    public class AuthorDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

         // Todo: replace this with DTO approach
        public ICollection<BookDTO> Books { get; set; } = new List<BookDTO>();
    }
}
