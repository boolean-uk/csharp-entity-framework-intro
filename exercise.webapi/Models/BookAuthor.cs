using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models
{
    [Table("book_author")]
    public class BookAuthor
    {
        public int Id { get; set; }
        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        [ForeignKey("Book")]
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
