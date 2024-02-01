using exercise.webapi.Models.Types;

namespace exercise.webapi.Models.DTOs;

public class BookDTO
{
    public string Title { get; set; }

    public static BookDTO BookToDTO(Book book)
    {
        return new BookDTO() { Title = book.Title };
    }
}
