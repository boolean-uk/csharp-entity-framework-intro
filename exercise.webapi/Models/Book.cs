using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models;

[Table("books")]
public class Book
{
    [Column("id")]
    public int Id { get; set; }
    [Column("title")]
    public string Title { get; set; }
    [Column("fk_author_id")]
    [ForeignKey("Author")]
    public int AuthorId { get; set; }
    public Author Author { get; set; }
}
