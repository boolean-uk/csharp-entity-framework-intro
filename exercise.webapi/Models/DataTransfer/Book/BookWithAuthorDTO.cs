using exercise.webapi.Models.DataTransfer.Author;
using exercise.webapi.Models.BaseModels;

namespace exercise.webapi.Models.DataTransfer.Book
{
    public class BookWithAuthorDTO
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public AuthorDTO Author { get; set; }

        public BookWithAuthorDTO(BaseModels.Book book)
        {
            ID = book.ID;
            Title = book.Title;
            Author = new AuthorDTO(book.Author);
        }
    }
}
