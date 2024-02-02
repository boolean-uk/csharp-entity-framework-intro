using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models
{
    [Table("book_author")]
    public class BookAuthor
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("book_id")]
        [ForeignKey("Book")]
        public int BookId { get; set; }
        public Book Book { get; set; }

        [Column("author_id")]
        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
