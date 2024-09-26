using exercise.webapi.Models;

namespace exercise.webapi.DTO.BookDTO
{
    public class BookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public BookAuthorDTO Author { get; set; }
        public BookPublisherDTO Publisher { get; set; }

        public BookDTO(Book book)
        {
            Id = book.Id;
            Title = book.Title;
            AuthorId = book.AuthorId;
            Author = new BookAuthorDTO(book.Author);
            Publisher = new BookPublisherDTO(book.Publisher);
        }

        public static List<BookDTO> FromRepository(IEnumerable<Book> books)
        {
            var result = new List<BookDTO>();
            foreach (var book in books)
            {
                result.Add(new BookDTO(book));
            }
            return result;
        }
    }
}
