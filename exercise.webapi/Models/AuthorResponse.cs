namespace exercise.webapi.Models
{
    public class AuthorResponse
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<BookDTO> Books { get; set; }

        public AuthorResponse (int id, string firstName, string lastName, string email, List<BookDTO> books)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Books = books;
        }
    }
}
