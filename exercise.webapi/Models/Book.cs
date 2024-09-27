using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<int> AuthorId { get; set; }
        public List<Author> Author { get; set; }
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
    }

    public class BookDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Publisher Publisher { get; set; }
    }

    public class BookAuthorDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Author> Author { get; set; }
    }
}
