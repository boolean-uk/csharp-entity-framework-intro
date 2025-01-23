using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }

        public BookDto(Book book)
        {
            Id = book.Id;
            Title = book.Title;
            AuthorId = book.AuthorId;
            AuthorName = $"{book.Author.FirstName} {book.Author.LastName}";
        }
    }
}
