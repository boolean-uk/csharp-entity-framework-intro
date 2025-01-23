using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class Book_get
    {
        public Book_get(Book book)
        {
            this.Id = book.Id;
            this.Title = book.Title;
            this.Author = new Book_get_Author(book.Author);
            this.Publisher = new Book_get_Publisher(book.Publisher);
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public Book_get_Author Author { get; set; }
        public Book_get_Publisher Publisher { get; set; }
    }
}
