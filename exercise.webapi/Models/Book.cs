using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models
{
    [Table("bands")]
    public class Book
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("author_id")]
        [ForeignKey("author_id")]
        public int AuthorId { get; set; }
        
        [Column("author")]
        public Author Author { get; set; }

        [Column("publisher_id")]
        [ForeignKey("publisher_id")]
        public int PublisherId { get; set; }
       
        [Column("publisher")]
        public Publisher Publisher { get; set; }
    }
}
