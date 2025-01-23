namespace exercise.webapi.DTO
{
    public record BookGet(int Id, string Title, AuthorInternal author);
    public record BookPost(string Title, int AuthorId);
    public record BookPut(int AuthorId);
    public record BookInternal(int id, string Title);
}
