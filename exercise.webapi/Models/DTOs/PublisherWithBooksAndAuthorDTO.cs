using exercise.webapi.Models.Types;

namespace exercise.webapi.Models.DTOs;

public class PublisherWithBooksAndAuthorDTO
{
    public string Name { get; set; }
    public ICollection<BookWithAuthorDTO> Books { get; set; } = new List<BookWithAuthorDTO>();

    public static PublisherWithBooksAndAuthorDTO PublisherToDTO(Publisher publisher)
    {
        var books = new List<BookWithAuthorDTO>();
        foreach (var book in publisher.Books)
        {
            books.Add(BookWithAuthorDTO.bookToDTO(book));
        }
        return new PublisherWithBooksAndAuthorDTO()
        {
            Name = publisher.Name,
            Books = books,
        };
    }
}
