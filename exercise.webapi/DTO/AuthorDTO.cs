namespace exercise.webapi.DTO
{
    public record AuthorGet(int Id, string FirstName, string LastName, string Email, IEnumerable<BookInternal> Books);
    public record AuthorInternal(int id, string FirstName, string LastName, string Email);
}
