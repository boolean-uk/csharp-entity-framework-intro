using exercise.webapi.DTO.BookDTO;
using exercise.webapi.Models;

namespace exercise.webapi.DTO.AuthorDTO
{
    public class AuthorBookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public BookPublisherDTO Publisher { get; set; }

        public AuthorBookDTO(Book book)
        {
            Id = book.Id;
            Title = book.Title;
            Publisher = new BookPublisherDTO(book.Publisher);
        }
    }
}
