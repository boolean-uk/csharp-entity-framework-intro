using exercise.webapi.Models.Types;

namespace exercise.webapi.Models.DTOs;

public class PublisherWithBooksAndAuthorDTO
{
    public string Name { get; set; }
    public ICollection<BookWithAuthorAndPublisherDTO> Books { get; set; } = new List<BookWithAuthorAndPublisherDTO>();

    public static PublisherWithBooksAndAuthorDTO PublisherToDTO(Publisher publisher)
    {
        var books = new List<BookWithAuthorAndPublisherDTO>();
        foreach (var book in publisher.Books)
        {
            books.Add(BookWithAuthorAndPublisherDTO.bookToDTO(book));
        }
        return new PublisherWithBooksAndAuthorDTO()
        {
            Name = publisher.Name,
            Books = books,
        };
    }
}
