using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models;

public class BookWithAuthorDTO
{
    public string Title { get; set; }
    public AuthorDTO Author { get; set; }
}
