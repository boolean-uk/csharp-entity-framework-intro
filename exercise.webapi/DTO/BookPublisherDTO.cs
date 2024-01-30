using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class BookPublisherDTO
    {
     
        public int Id { get; set; }
        public string Title { get; set; }

        public PublisherPlainDTO Publisher { get; set; }

        public BookPublisherDTO(Book book)
        {
            Id = book.Id;
            Title = book.Title;
            Publisher = new PublisherPlainDTO(book.Publisher);
        }
    }
}
