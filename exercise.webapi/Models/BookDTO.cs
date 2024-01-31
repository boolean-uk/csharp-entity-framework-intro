using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models;

public class BookDTO
{
    public string Title { get; set; }
    public AuthorDTO Author { get; set; }
}
