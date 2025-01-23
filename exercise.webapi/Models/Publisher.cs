using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.Text.Json.Serialization;


namespace exercise.webapi.Models
{
    public class Publisher
    {
        public int Id { get; set; } 
        public string FirstName { get; set; }  
        public string LastName { get; set; }
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }

    public class PublisherDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class PublisherAndBooksWithAuthorDTO 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [JsonInclude]
        public ICollection<BookAndAuthorDTO> Books { get; set; } = new List<BookAndAuthorDTO>();
    }

    public class BookAndAuthorDTO
    {
        public string BookTitle { get; set; }
        public string AuthorName { get; set; }
    }


}
