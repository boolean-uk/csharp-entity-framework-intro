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

        [Column("author")]
        public int AuthorId { get; set; }
        public Author Author { get; set; }

        [Column("publisher")]
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
    }
}
