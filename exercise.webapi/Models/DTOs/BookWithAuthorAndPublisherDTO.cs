using exercise.webapi.Models.Types;
using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models.DTOs;

public class BookWithAuthorAndPublisherDTO
{
    public string Title { get; set; }
    public AuthorDTO Author { get; set; }
    public PublisherDTO Publisher { get; set; }
    public static BookWithAuthorAndPublisherDTO bookToDTO(Book book)
    {
        return new BookWithAuthorAndPublisherDTO()
        {
            Title = book.Title,
            Author = AuthorDTO.AuthorToDTO(book.Author),
            Publisher = PublisherDTO.PublisherToDTO(book.Publisher)
        };
    }
}
