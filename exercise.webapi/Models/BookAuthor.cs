using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models
{
    public class BookAuthor
    {
        [ForeignKey("Book")]
        [Column("bookid")]
        public int BookId { get; set; }
        public Book Book { get; set; }
        [ForeignKey("Author")]
        [Column("authorid")]
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
