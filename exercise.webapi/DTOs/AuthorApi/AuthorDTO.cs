using exercise.webapi.Models;

namespace exercise.webapi.DTOs.AuthorApi
{
    public class AuthorDTO
    {
        public AuthorDTO(string authorName, string email, List<BookDTO> books)
        {
            AuthorName = authorName;
            Email = email;
            Books = books;
        }

        public string AuthorName { get; set; }

        public string Email { get; set; }

        public List<BookDTO> Books { get; set; }
        
    }
}
