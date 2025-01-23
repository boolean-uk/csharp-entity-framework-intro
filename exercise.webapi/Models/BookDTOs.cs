namespace exercise.webapi.Models;

public class BookPostDTO
{
    public string Title { get; set; }
    public int AuthorId { get; set; }
    public int PublisherId { get; set; }
}

public class BookDTO
{
    public int Id { get; set; }
    public string Title { get; set; }

    public AuthorStrippedDTO Author { get; set; }
    public PublisherStrippedDto Publisher { get; set; }

    public BookDTO(Book book)
    {
        this.Id = book.Id;
        this.Title = book.Title;
        this.Author = new AuthorStrippedDTO(book.Author);
        this.Publisher = new PublisherStrippedDto(book.Publisher);
    }
}

public class BookStrippedNoPublisherDTO
{
    public int Id { get; set; }
    public string Title { get; set; }
    public AuthorStrippedDTO Author { get; set; }

    public BookStrippedNoPublisherDTO(Book book)
    {
        this.Id = book.Id;
        this.Title = book.Title;
        this.Author = new AuthorStrippedDTO(book.Author);
    }
}

public class BookStrippedDTO
{
    public int Id { get; set; }
    public string Title { get; set; }
    public PublisherStrippedDto Publisher { get; set; }

    public BookStrippedDTO(Book book)
    {
        this.Id = book.Id;
        this.Title = book.Title;
        this.Publisher = new PublisherStrippedDto(book.Publisher);
    }
}
