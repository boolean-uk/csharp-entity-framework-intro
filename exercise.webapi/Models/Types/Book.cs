using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models.Types;

[Table("books")]
public class Book
{
    [Column("id")]
    public int Id { get; set; }
    [Column("title")]
    public string Title { get; set; }
    public ICollection<AuthorBook> AuthorBooks { get; set; } = new List<AuthorBook>();
    [Column("fk_publisher_id")]
    [ForeignKey("Publisher")]
    public int PublisherId { get; set; }
    public Publisher Publisher { get; set; }
}
