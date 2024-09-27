using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models.Types;

[Table("publisher")]
public class Publisher
{
    [Column("id")]
    public int Id { get; set; }
    [Column("name")]
    public string Name { get; set; }
    public ICollection<Book> Books { get; set; } = new List<Book>();
}
