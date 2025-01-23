using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class BookDto
    {
        public string Title { get; set; }
        public AuthorDto Author { get; set; }
        public string Publisher { get; set; }

        public BookDto(Book book)
        {
            Title = book.Title;
            Author = new AuthorDto(book.Author);
            Publisher = book.Publisher.Name;
        }

    }
}
