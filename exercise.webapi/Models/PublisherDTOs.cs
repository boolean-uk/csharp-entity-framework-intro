namespace exercise.webapi.Models;

public class PublisherDTO
{
    public string Name { get; set; }
    public ICollection<BookStrippedNoPublisherDTO> Books { get; set; } =
        new List<BookStrippedNoPublisherDTO>();

    public PublisherDTO(Publisher publisher)
    {
        this.Name = publisher.Name;
        this.Books = publisher.Books.Select(b => new BookStrippedNoPublisherDTO(b)).ToList();
    }
}

public class PublisherStrippedDto
{
    public int Id { get; set; }
    public string Name { get; set; }

    public PublisherStrippedDto(Publisher publisher)
    {
        this.Id = publisher.Id;
        this.Name = publisher.Name;
    }
}
