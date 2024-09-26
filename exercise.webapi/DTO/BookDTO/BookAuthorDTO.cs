using exercise.webapi.Models;

namespace exercise.webapi.DTO.BookDTO
{
    public class BookAuthorDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public BookAuthorDTO(Author author)
        {
            Id = author.Id;
            FirstName = author.FirstName;
            LastName = author.LastName;
            Email = author.Email;
        }
    }
}
