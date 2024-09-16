using exercise.webapi.Models;

namespace exercise.webapi.DTOs
{
    public class AuthorResponseDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public List<AuthorBookDTO> AuthorsBooks { get; set; } = new List<AuthorBookDTO>();

        public AuthorResponseDTO(Author author)
        {
            Id = author.Id;
            Email = author.Email;
            FirstName = author.FirstName;
            LastName = author.LastName;

            foreach (BookAuthor bookAuthor in author.BookAuthors)
            {
                AuthorsBooks.Add(new AuthorBookDTO(bookAuthor));
            }

        }


    }
}




