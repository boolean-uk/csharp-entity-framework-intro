using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class AuthorDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        //public ICollection<BookDTO3> Books { get; set; } = new List<BookDTO3>();
    }
}
