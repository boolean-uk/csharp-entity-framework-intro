using exercise.webapi.Models.DataTransfer.Author;

namespace exercise.webapi.Models.DataTransfer.Book
{
    public class BookDTO
    {
        public int ID { get; set; }
        public string Title { get; set; }

        public BookDTO(BaseModels.Book book)
        {
            ID = book.ID;
            Title = book.Title;
        }
    }
}
