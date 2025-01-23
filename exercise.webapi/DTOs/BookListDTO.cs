using exercise.webapi.Models;

namespace exercise.webapi.DTOs
{
    public class BookListDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public BookListDTO(Book book)
        {
            Id = book.Id;
            Title = book.Title;
        }
    }
}
