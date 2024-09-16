using exercise.webapi.DTO;
using System.Text.Json.Serialization;
using static exercise.webapi.DTO.BookDTO;


namespace exercise.webapi.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        // [JsonIgnore] // Todo: replace this with DTO approach
        public ICollection<Book> Books { get; set; } = new List<Book>();

        public AuthorDTO ToDTO()
        {
            return new AuthorDTO { Id = Id, FirstName = FirstName, LastName = LastName, Email = Email };
        }

        public AuthorResponseDTO ToDTOResponse()
        {
            var result = new List<BookGet>();
            foreach (var book in Books)
            {
                result.Add(book.ToTDOResponse());
            }
            return new AuthorResponseDTO { Id = Id, FirstName = FirstName, LastName = LastName, Email = Email, Books = result };
        }

    }
}
