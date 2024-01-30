using System.Text.Json.Serialization;

namespace exercise.webapi.Models
{
    public class AuthorBook
    {
    public class BookAuthor
    {

        public int AuthorId { get; set; }
        public Author Author { get; set; } // = null!;
        public int BookId { get; set; }
        public Book Book { get; set; } // = null!;
    }
    }
}
