using exercise.webapi.Models.DataTransfer.Publisher;

namespace exercise.webapi.Models.DataTransfer.Book
{
    public class BookWithPublisherDTO
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public PublisherDTO Publisher { get; set; }

        public BookWithPublisherDTO(BaseModels.Book book)
        {
            ID = book.ID;
            Title = book.Title;
            Publisher = new PublisherDTO(book.Publisher);
        }
    }
}
