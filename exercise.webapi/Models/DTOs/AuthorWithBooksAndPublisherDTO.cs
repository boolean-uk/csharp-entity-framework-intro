using exercise.webapi.Models.Types;

namespace exercise.webapi.Models.DTOs;

public class AuthorWithBooksAndPublisherDTO
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public ICollection<BookWithPublisherDTO> Books { get; set; } = new List<BookWithPublisherDTO>();

    public static AuthorWithBooksAndPublisherDTO AuthorToDTO(Author author)
    {
        var books = new List<BookWithPublisherDTO>();
        foreach (var book in author.Books)
        {
            books.Add(BookWithPublisherDTO.BookToDTO(book));
        }
        return new AuthorWithBooksAndPublisherDTO()
        {
            FirstName = author.FirstName,
            LastName = author.LastName,
            Email = author.Email,
            Books = books,
        };
    }
}
