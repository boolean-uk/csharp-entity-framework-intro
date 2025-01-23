using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class BookDto
    {
        public string Title { get; set; }
        public List<AuthorDto> Authors { get; set; }
        public string Publisher { get; set; }

        public BookDto(Book book)
        {
            Title = book.Title;
            Authors = book.Authors.Select(a => new AuthorDto(a)).ToList();
            Publisher = book.Publisher.Name;
        }

    }
}
