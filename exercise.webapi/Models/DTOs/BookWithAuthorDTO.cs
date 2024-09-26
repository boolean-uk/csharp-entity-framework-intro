
namespace exercise.webapi.Models.DTOs {

public class BookWithAuthorDTO
{
    public int Id { get; set; }
    public string Title { get; set; }

    public AuthorDto Author { get; set; }

    public BookWithAuthorDTO(int id, string title, AuthorDto author)
    {
        Id = id;
        Title = title;
        Author = author;
    }
}
}