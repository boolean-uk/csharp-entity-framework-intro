using exercise.webapi.Models;
using System.Text.Json.Serialization;

namespace exercise.webapi.DTO
{
    public class AuthorDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public ICollection<string> Books { get; set; } = new List<string>();

        public AuthorDto(Author author, List<string> books) 
        {
            Id = author.Id;
            FirstName = author.FirstName;
            LastName = author.LastName; 
            Email = author.Email;
            Books = books;
            
        }

    }
}
