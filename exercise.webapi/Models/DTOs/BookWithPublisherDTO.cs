using exercise.webapi.Models.Types;

namespace exercise.webapi.Models.DTOs;

public class BookWithPublisherDTO
{
    public string Title { get; set; }
    public PublisherDTO Publisher { get; set; }

    public static BookWithPublisherDTO BookToDTO(Book book)
    {
        return new BookWithPublisherDTO()
        {
            Title = book.Title,
            Publisher = PublisherDTO.PublisherToDTO(book.Publisher),
        };
    }
}
