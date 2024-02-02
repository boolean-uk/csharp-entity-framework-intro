using exercise.webapi.Models;
using exercise.webapi.DTO_s;
using System.Text.Json.Serialization;

namespace exercise.webapi.DTO_s
{
    public class BookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public int PublisherId { get; set; }

        //public string PublisherName { get; set; }

    }
}
