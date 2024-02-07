using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace exercise.webapi.Models.DatabaseModels
{
    [Table("books")]
    public class Book
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("title")]
        public string Title { get; set; }

        [ForeignKey("Author")]
        [Column("fk_author_id")]
        public int AuthorId { get; set; }
        public Author Author { get; set; }

        [ForeignKey("Publisher")]
        [Column("fk_publisher_id")]
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
    }
}