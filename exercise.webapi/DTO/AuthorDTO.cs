using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
   public class AuthorDto{
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public string Email { get; set; }

        public AuthorDto(Author author)
        {
            Id = author.Id;
            FirstName = author.FirstName;
            LastName = author.LastName;
            Email = author.Email;
        }
    }
      

public class AutherResponseDto{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    public ICollection<BookDto> Books { get; set; } = new List<BookDto>();

    public ICollection<PublisherDTO> Publishers { get; set; } = new List<PublisherDTO>();

    public AutherResponseDto(Author author)
    {
        Id = author.Id;
        Name = author.FirstName + " " + author.LastName;
        Email = author.Email;
        Books = new List<BookDto>();
        foreach (var book in author.Books)
        {
            Books.Add(new BookDto(book));
        }
        
    }

    public static List<AutherResponseDto> FromRepository(IEnumerable<Author> authors)
    {
        var results = new List<AutherResponseDto>();
        foreach (var author in authors)
        {
            results.Add(new AutherResponseDto(author));
        }
        return results;
    }
}
}