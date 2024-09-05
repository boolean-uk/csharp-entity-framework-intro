using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models
{
    [Table("book_authors")]
    public class BookAuthor
    {
        [Column("bookauthor_id")]
        public int Id { get; set; }

        [Column("fk_book_id")]
        [ForeignKey("Book")]
        public int BookId { get; set; }
        public Book Book { get; set; }

        [Column("fk_author_id")]
        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
