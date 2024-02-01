using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models
{
    [Table("book")]
    public class Book
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("author_id")]
       [ForeignKey("Author")]
        public int AuthorId { get; set; }
        [Column("publisher_id")]
        [ForeignKey("Publisher")]
        public int PublisherId { get; set; }

        public Author Author { get; set; }
        public Publisher Publisher { get; set; }
    }
}
