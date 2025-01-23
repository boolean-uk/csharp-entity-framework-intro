using System.ComponentModel.DataAnnotations;

namespace exercise.webapi.Dto;

public class BookPut
{
    [MinLength(1)]
    [MaxLength(100)]
    public string Title { get; set; }
    public int AuthorId { get; set; }
}