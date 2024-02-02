using exercise.webapi.Models.BaseModels;

namespace exercise.webapi.Models.DataTransfer.Book
{
    public class BookResultDTO
    {
        public BookResultDTO(BaseModels.Book book)
        {
            this.ID = book.ID;
            this.Title = book.Title;
            this.AuthorID = book.AuthorID;
        }
        public int ID { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
    }
}
