using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class AuthorDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public ICollection<BookWithoutAuthor> Books { get; set; } = new List<BookWithoutAuthor>();
    }
}
