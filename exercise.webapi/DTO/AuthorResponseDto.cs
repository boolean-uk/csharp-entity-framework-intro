using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class AuthorResponseDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<BookPublisherDto> Books { get; set; }
        public AuthorResponseDto(Author author)
        {
            FirstName = author.FirstName;
            LastName = author.LastName;
            Email = author.Email;
            Books = author.Books.Select(book => new BookPublisherDto(book)).ToList();
        }
    }
}
