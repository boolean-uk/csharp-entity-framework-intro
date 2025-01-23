using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class AuthorDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
