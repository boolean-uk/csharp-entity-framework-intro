using exercise.webapi.Models.Types;
using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models.DTOs;

public class BookWithAuthorDTO
{
    public string Title { get; set; }
    public AuthorDTO Author { get; set; }

    public static BookWithAuthorDTO bookToDTO(Book book)
    {
        return new BookWithAuthorDTO()
        {
            Title = book.Title,
            Author = AuthorDTO.AuthorToDTO(book.Author),
        };
    }
}
