
namespace exercise.webapi.Models.DTOs {
    public record BookUpdateDTO(int AuthorId, string? Title);

    public record AuthorUpdatePayload(string? FirstName, string? LastName, ICollection<BookAuthor>? Books);

    public record BookCreatePayload(string Title, int PublisherId);

    public record PublisherCreatePayload(string Company);
}