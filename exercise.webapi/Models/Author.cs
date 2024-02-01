using System.Text.Json.Serialization;

namespace exercise.webapi.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        [JsonIgnore] // Todo: replace this with DTO approach
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }

    public class AuthorPut
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
    public class AuthorDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

    }

    public class SimpleAuthorDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    public class AuthorAndBooksDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public ICollection<SimpleBookDTO> Books { get; set; } = new List<SimpleBookDTO>();
    }




}
