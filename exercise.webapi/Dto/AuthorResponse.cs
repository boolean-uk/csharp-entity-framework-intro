using System.Text.Json.Serialization;

namespace exercise.webapi.Dto;

public class AuthorResponse
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public BookResponse[]? Books { get; set; }
    
    public AuthorResponse(Models.Author author)
    {
        Id = author.Id;
        FirstName = author.FirstName;
        LastName = author.LastName;
        Email = author.Email;
    }
}