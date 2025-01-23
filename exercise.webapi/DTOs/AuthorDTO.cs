using exercise.webapi.Models;

namespace exercise.webapi.DTOs
{
    public class AuthorDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<BookListDTO> Books { get; set; }

        public AuthorDTO(Author author)
        {
            Id = author.Id;
            FirstName = author.FirstName;
            LastName = author.LastName;
            Email = author.Email;
            Books = author.Books?.Select(b => new BookListDTO(b)).ToList() ?? new List<BookListDTO>();
        }

        public AuthorDTO(int id, string firstName, string lastName, string email, List<BookListDTO> books = null)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Books = books ?? new List<BookListDTO>();
        }
    }
}
