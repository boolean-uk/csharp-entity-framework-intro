using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class Author_get_Book
    {
        public Author_get_Book(Book book)
        {
            this.Id = book.Id;
            this.Title = book.Title;
        }
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
