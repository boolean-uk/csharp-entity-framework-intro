using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class AuthorDTO
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public AuthorDTO(Author author)
        {
            Id = author.Id;
            Firstname = author.FirstName;
            LastName = author.LastName;
            Email = author.Email;
        }
    }
}
