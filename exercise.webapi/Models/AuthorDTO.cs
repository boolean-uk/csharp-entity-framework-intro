namespace exercise.webapi.Models
{
    public class AuthorDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public IEnumerable<BookDTO> Books { get; set; }
    }
}
