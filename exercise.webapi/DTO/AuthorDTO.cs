using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class AuthorDTO
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public List<AuthorBookDTO> Books { get; set; }
    }
}
