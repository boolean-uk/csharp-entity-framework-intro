using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class AuthorResponseDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

     
        public ICollection<AuthorWithPublisherAndBookDTO> Books { get; set; } = new List<AuthorWithPublisherAndBookDTO>();

        public AuthorResponseDTO(Author author) {
            Id = author.Id;
            FirstName = author.FirstName;
            LastName = author.LastName;
            Email = author.Email;

            Books = new List<AuthorWithPublisherAndBookDTO>();
            foreach (var item in author.Books)
            {
                Books.Add(new AuthorWithPublisherAndBookDTO(item));
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
