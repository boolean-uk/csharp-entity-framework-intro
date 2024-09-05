using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class AuthorDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public IEnumerable<BookDto> Books { get; set; }

    }
}
