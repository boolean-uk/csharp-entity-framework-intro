namespace exercise.webapi.DTO
{
    public record BookPost(string Title, int AuthorId, int PublisherId);
    public record BookPut(string? Title);
    public record BookView(int Id, string Title, IEnumerable<AuthorInternal> Authors, PublisherInternal Publisher, CheckoutInternal? Checkout);
    public record BookInternal(int Id, string Title);
    public record BookInternalPublisher(int Id, string Title, PublisherInternal Publisher);
    public record BookInternalAuthor(int Id, string Title, IEnumerable<AuthorInternal> Authors);
    public record BookInternalAuthorPublisher(int Id, string Title, IEnumerable<AuthorInternal> Authors, PublisherInternal Publisher);
}
