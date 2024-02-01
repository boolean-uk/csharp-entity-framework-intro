using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
    public class BookAuthorlessDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
    public class BookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public AuthorBooklessDTO author {  get; set; }
    }
    public class InputBook
    {
        public string Title { get; set; }
        public int AuthorId { get; set; }
    }
}
