using exercise.webapi.Models.Types;

namespace exercise.webapi.Models.DTOs;

public class BookWithAuthorAndPublisherDTO
{
    public string Title { get; set; }
    public ICollection<AuthorDTO> Authors { get; set; } = new List<AuthorDTO>();
    public PublisherDTO Publisher { get; set; }
    public static BookWithAuthorAndPublisherDTO bookToDTO(Book book)
    {
        var authors =  new List<AuthorDTO>();
        foreach (var authorBook in book.AuthorBooks)
        {
            authors.Add(AuthorDTO.AuthorToDTO(authorBook.Author));
        }
        return new BookWithAuthorAndPublisherDTO()
        {
            Title = book.Title,
            Authors = authors,
            Publisher = PublisherDTO.PublisherToDTO(book.Publisher)
        };
    }
}
