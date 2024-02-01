using exercise.webapi.Models.Types;

namespace exercise.webapi.Models.DTOs;

public class PublisherDTO
{
    public string Name { get; set; }

    public static PublisherDTO PublisherToDTO(Publisher publisher)
    {
        return new PublisherDTO() { Name = publisher.Name };
    }
}
