using exercise.webapi.Models.DatabaseModels;
using exercise.webapi.Models.DataTransfer.Books;
using System.Text.Json.Serialization;

namespace exercise.webapi.Models.DataTransfer.Authors
{
    public class AuthorDTO
    {

        public AuthorDTO(int id, string firstName, string lastName, string email, IEnumerable<Book> books)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            foreach (Book book in books) 
            {
                Books.Add(new BookInAuthorDTO(book.Id, book.Title, book.Publisher));
            }
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public ICollection<BookInAuthorDTO> Books { get; set; } = new List<BookInAuthorDTO>();
    }
}
