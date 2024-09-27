using exercise.webapi.Models.Types;

namespace exercise.webapi.Models.DTOs;

public class AuthorDTO
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

    public static AuthorDTO AuthorToDTO(Author author)
    {
        return new AuthorDTO()
        {
            FirstName = author.FirstName,
            LastName = author.LastName,
            Email = author.Email,
        };
    }
}
