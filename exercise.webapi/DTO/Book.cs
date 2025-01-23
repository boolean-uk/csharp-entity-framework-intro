namespace exercise.webapi.DTO
{
    public record BookPost(string Title, int AuthorId);
    public record BookPut(string? Title, int? AuthorId);
    public record BookView(int Id, string Title, AuthorInternal Author);
    public record BookInternal(int Id, string Title);
}
