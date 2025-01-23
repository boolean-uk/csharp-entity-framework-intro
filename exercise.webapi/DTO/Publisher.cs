namespace exercise.webapi.DTO
{
    public record PublisherPost(string Name);
    public record PublisherPut(string? Name);
    public record PublisherView(int Id, string Name, IEnumerable<BookInternalAuthor> Books);
    public record PublisherInternal(int Id, string Name);
}
