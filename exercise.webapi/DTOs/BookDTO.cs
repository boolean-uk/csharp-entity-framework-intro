using exercise.webapi.Models;

namespace exercise.webapi.DTOs
{
    public class BookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int AuthorId { get; set; }

        public BookDTO(Book book)
        {
            Id = book.Id;
            Title = book.Title;
            AuthorId = book.AuthorId;
        }
    }
}
