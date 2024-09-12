using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public struct AuthorDTO
    {
        public int Id { get; internal set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
