using exercise.webapi.Models;

namespace exercise.webapi.ViewModels
{
    public class BookDTO
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        public BookDTO(Book book)
        {
            this.Id = book.Id;
            this.Title = book.Title;
        }
    }
}
