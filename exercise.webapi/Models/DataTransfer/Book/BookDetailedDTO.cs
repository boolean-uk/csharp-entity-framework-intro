using exercise.webapi.Models.DataTransfer.Author;
using exercise.webapi.Models.BaseModels;
using exercise.webapi.Models.DataTransfer.Publisher;

namespace exercise.webapi.Models.DataTransfer.Book
{
    public class BookDetailedDTO
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public AuthorDTO Author { get; set; }
        public PublisherDTO Publisher { get; set; }

        public BookDetailedDTO(BaseModels.Book book)
        {
            ID = book.ID;
            Title = book.Title;
            Author = new AuthorDTO(book.Author);
            Publisher = new PublisherDTO(book.Publisher);
        }
    }
}
