using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace exercise.webapi.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public IEnumerable<Book> Books { get; set; } = new List<Book>();
    }

    public class PublisherDTO
    {
        public string Name { get; set; }
        public List<BookAuthorlessDTO> Books { get; set; } = new List<BookAuthorlessDTO>();
    }
    public class PublisherBooklessDTO
    {
        public string Name { get; set; }
    }
}
