using System.ComponentModel.DataAnnotations;

namespace exercise.webapi.Dto;

public class BookPost
{
    [Required]
    [MinLength(1)]
    [MaxLength(100)]
    public string Title { get; set; }
    [Required]
    public int AuthorId { get; set; }
}