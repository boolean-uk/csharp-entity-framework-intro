using System.ComponentModel.DataAnnotations.Schema;
using exercise.webapi.DTO;

namespace exercise.webapi.Models
{
    public class AuthorResponseDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public ICollection<BookDTO> Books { get; set; } = new List<BookDTO>();

        public AuthorResponseDTO(Author author)
        {
            Id = author.Id;
            FirstName = author.FirstName;
            LastName = author.LastName;
            Email = author.Email;
            Books = new List<BookDTO>();
            foreach (var authorBook in author.AuthorBooks)
            {
                Books.Add(new BookDTO(authorBook.Book, author.Id));
            }

        }

        public static List<AuthorResponseDTO> FromRepository(IEnumerable<Author> authors){
            var results = new List<AuthorResponseDTO>();
            foreach (var author in authors)
            {
                results.Add(new AuthorResponseDTO(author));
            }
            return results;
        }

        public static AuthorResponseDTO FromRepository(Author Author){
            return new AuthorResponseDTO(Author);
        }

    }
}
