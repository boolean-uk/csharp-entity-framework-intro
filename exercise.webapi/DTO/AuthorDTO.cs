using System.Text.Json.Serialization;

namespace exercise.webapi.Models
{
    public class AuthorDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
