namespace exercise.webapi.DTOs
{
    public class payloads
    {
        public record CreateBookPayload(string Title);
        public record UpdateBookPayload(string newTitle);
        public record CreateAuthorPayload(string FirstName, string LastName, string Email);
        public record UpdateAuthorPayload(string newFirstName, string newLastName, string newEmail);
    }
}
