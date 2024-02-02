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

        [Column("fk_author_id")]
        [ForeignKey("Author")]
        [JsonIgnore]
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}