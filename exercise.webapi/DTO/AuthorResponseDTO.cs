using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class AuthorResponseDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public ICollection<BookDTO> Books { get; set; } = new List<BookDTO>();

        public AuthorResponseDTO(Author author) {
            Id = author.Id;
            FirstName = author.FirstName;
            LastName = author.LastName;
            Email = author.Email;

            Books = new List<BookDTO>();
            foreach (var book in author.Books)
            {
                Books.Add(new BookDTO(book));
            }
        }


        public static List<AuthorResponseDTO> FromRepository(IEnumerable<Author> authors)
        {
            var result = new List<AuthorResponseDTO>();
            foreach (var author in authors) {
                result.Add(new AuthorResponseDTO(author));
            }

            return result;
        }

    }
}
