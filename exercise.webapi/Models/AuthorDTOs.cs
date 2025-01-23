namespace exercise.webapi.Models;

public class AuthorDTO
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

    public ICollection<BookStrippedDTO> Books { get; set; } = new List<BookStrippedDTO>();

    public AuthorDTO(Author author)
    {
        this.Id = author.Id;
        this.FirstName = author.FirstName;
        this.LastName = author.LastName;
        this.Email = author.Email;
        this.Books = author.Books.Select(b => new BookStrippedDTO(b)).ToList();
    }
}

public class AuthorStrippedDTO
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

    public AuthorStrippedDTO(Author author)
    {
        this.Id = author.Id;
        this.FirstName = author.FirstName;
        this.LastName = author.LastName;
        this.Email = author.Email;
    }
}
