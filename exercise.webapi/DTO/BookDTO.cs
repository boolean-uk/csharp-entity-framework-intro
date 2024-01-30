using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class BookDto{
        public int Id { get; set; }
        public string Title { get; set; }
        public AuthorDto Author { get; set; }
        public PublisherDTO Publisher { get; set; }

        public BookDto(Book book)
        {
            Id = book.Id;
            Title = book.Title;
            Publisher = new PublisherDTO(book.Publisher);
            Author = new AuthorDto(book.Author);
        }
    }

    public class BookResponseDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public AuthorDto Author { get; set; }
        public PublisherDTO Publisher { get; set; }

        public BookResponseDto(Book book)
        {
            Id = book.Id;
            Title = book.Title;
            Author = new AuthorDto(book.Author);
            Publisher = new PublisherDTO(book.Publisher);
        }

        public static List<BookResponseDto> FromRepository(IEnumerable<Book> books)
        {
        var results = new List<BookResponseDto>();
        foreach (var book in books)
        {
            results.Add(new BookResponseDto(book));
        }
        return results;
        }
    }

}