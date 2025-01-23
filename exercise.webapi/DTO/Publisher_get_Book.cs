using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class Publisher_get_Book
    {
        public Publisher_get_Book(Book book)
        {
            this.Id = book.Id;
            this.Title = book.Title;
            this.Author = new Book_get_Author(book.Author);
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public Book_get_Author Author { get; set; }
    }
}
