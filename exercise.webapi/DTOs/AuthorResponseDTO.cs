using exercise.webapi.Models;

namespace exercise.webapi.DTOs
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
            Email = author.Email;
            FirstName = author.FirstName;
            LastName = author.LastName;

            //Books = author.BookAuthors.Select(ba => new BookDTO(ba.Book)).ToList();
        }

        public static List<AuthorResponseDTO> FromRepository(IEnumerable<Author> authors)
        {
            var results = new List<AuthorResponseDTO>();
            foreach (var author in authors)
            {
                results.Add(new AuthorResponseDTO(author));

            }
            return results;
        }

    }
}




