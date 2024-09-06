using exercise.webapi.Models;

namespace exercise.webapi.ViewModels
{
    public class AuthorDTO
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }

        public AuthorDTO(Author author)
        {
            this.Id = author.Id;
            this.FirstName = author.FirstName;
            this.LastName = author.LastName;
            this.Email = author.Email;
        }
    }
}
