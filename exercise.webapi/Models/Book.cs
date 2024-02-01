using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
    }

    public class BookPost
    {
        public string Title { get; set; }
        public int AuthorId { get; set; }
    }

    public class BookDTO
    {
        // id
        public string Title { get; set; }

        // author id
        public AuthorDTO Author { get; set; }
    }

    public class SimpleBookDTO
    {
        public string Title { get; set; }
    }

    public class BookAndPublisherDTO
    {
        public string Title { get; set; }
        public string PublisherName { get; set; }
    }
}
