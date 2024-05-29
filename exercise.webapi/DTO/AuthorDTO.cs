 using exercise.webapi.Models;
namespace exercise.webapi.DTO
{
    public class AuthorDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // constructor
        public AuthorDTO(Author author) 
        { 
            Id = author.Id;
            FirstName = author.FirstName;
            LastName = author.LastName;
        }
    }
}
