using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models
{
    [Table("books")]
    public class Book
    {
        [Column("id")]
        public int Id { get; set; }
        
        [Column("title")]
        public string Title { get; set; }
        
        [Column("fk_publisher_id")]
        [ForeignKey("Publisher")]
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
        public IEnumerable<Author> Authors { get; set; }

    }
}
