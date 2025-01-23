using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class BookPublisherDto
    {
        public string Title { get; set; }
        public string Publisher { get; set; }
        public BookPublisherDto(Book book)
        {
            Title = book.Title;
            Publisher = book.Publisher.Name;
        }
    }
}
