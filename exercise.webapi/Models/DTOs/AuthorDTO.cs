using exercise.webapi.Models.Types;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

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
