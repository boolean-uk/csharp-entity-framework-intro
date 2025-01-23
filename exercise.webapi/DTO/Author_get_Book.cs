using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class Author_get_Book
    {
        public Author_get_Book(Book book)
        {
            this.Id = book.Id;
            this.Title = book.Title;
            this.Publisher = new Book_get_Publisher(book.Publisher);
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public Book_get_Publisher Publisher { get; set; }
    }
}
