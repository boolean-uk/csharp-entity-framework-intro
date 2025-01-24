namespace exercise.webapi.DTO
{
    public record AuthorPost(string FirstName, string LastName, string Email);
    public record AuthorPut(string? FirstName, string? LastName, string? Email);
    public record AuthorInternal(int Id, string FirstName, string LastName, string Email);
    public record AuthorView(int Id, string FirstName, string LastName, string Email, IEnumerable<BookInternalPublisher> Books);
}
