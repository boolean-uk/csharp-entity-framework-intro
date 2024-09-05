using exercise.webapi.Models;

namespace exercise.webapi.DtoModels
{
    public class AuthorDto
    { 
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public AuthorDto(Author author)
        {
            Id = author.Id;
            FirstName = author.FirstName;
            LastName = author.LastName;
            Email = author.Email;
        }
    }
}
