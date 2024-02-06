using System.Text.Json.Serialization;

namespace exercise.webapi.Models.DataTransfer.Books
{
    public class AuthorInBookDTO(int AuthorId, string FirstName, string LastName, string Email)
    {
        public int AuthorId { get; set; } = AuthorId;
        public string FirstName { get; set; } = FirstName;
        public string LastName { get; set; } = LastName;
        public string Email { get; set; } = Email;
    }
}
