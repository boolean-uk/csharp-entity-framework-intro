using exercise.webapi.DTO.BookDTO;
using exercise.webapi.Models;

namespace exercise.webapi.DTO.PublisherDTO
{
    public class BookPublisherDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public BookAuthorDTO Author { get; set; }

        public BookPublisherDTO(Book book)
        {
            Id = book.Id;
            Title = book.Title;
            AuthorId = book.AuthorId;
            Author = new BookAuthorDTO(book.Author);
        }
    }
}
