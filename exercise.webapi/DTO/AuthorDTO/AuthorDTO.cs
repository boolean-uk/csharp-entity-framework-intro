using exercise.webapi.Models;

namespace exercise.webapi.DTO.AuthorDTO
{
    public class AuthorDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public ICollection<AuthorBookDTO> Books { get; set; }

        public AuthorDTO(Author author)
        {
            Id = author.Id;
            FirstName = author.FirstName;
            LastName = author.LastName;
            Email = author.Email;
            Books = new List<AuthorBookDTO>();
            foreach (var book in author.Books)
            {
                Books.Add(new AuthorBookDTO(book));
            }
        }

        public static List<AuthorDTO> FromRepository(IEnumerable<Author> authors)
        {
            var result = new List<AuthorDTO>();
            foreach (var author in authors)
            {
                result.Add(new AuthorDTO(author));
            }
            return result;
        }
    }
}
