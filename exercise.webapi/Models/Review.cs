using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models;

[Table("reviews")]
public class Review
{
    [Column("id")]
    public int Id { get; set; }
    
    [Column("rating")]
    public int Rating { get; set; }
    
    [Column("name")]
    public string Name { get; set; }
    public string Content { get; set; }
    public int BookId { get; set; }
    public Book Book { get; set; }
}