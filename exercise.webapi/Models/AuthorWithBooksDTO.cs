using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models;

public class AuthorWithBooksDTO
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public ICollection<BookDTO> Books { get; set; } = new List<BookDTO>();
}
