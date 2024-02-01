using exercise.webapi.Models.Types;

namespace exercise.webapi.Models.DTOs;

public class AuthorWithBooksDTO
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public ICollection<BookDTO> Books { get; set; } = new List<BookDTO>();

    public static AuthorWithBooksDTO AuthorToDTO(Author author)
    {
        var books = new List<BookDTO>();
        foreach (var book in author.Books)
        {
            books.Add(BookDTO.BookToDTO(book));
        }
        return new AuthorWithBooksDTO()
        {
            FirstName = author.FirstName,
            LastName = author.LastName,
            Email = author.Email,
            Books = books,
        };
    }
}
