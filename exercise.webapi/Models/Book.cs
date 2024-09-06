using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models
{
    [Table("Book")]
    public class Book
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [ForeignKey("author_id")]
        public int AuthorId { get; set; }

        public Author Author { get; set; }
    }
}
