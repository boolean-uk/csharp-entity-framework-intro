using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class BookResponseDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public AuthorDTO Author { get; set; }

        public PublisherPlainDTO Publisher { get; set; }

        public BookResponseDTO(Book book)
        {
            Id = book.Id;
            Title = book.Title;
            Author = new AuthorDTO(book.Author);
            Publisher = new PublisherPlainDTO(book.Publisher);
        }

        public static List<BookResponseDTO> FromRepository(IEnumerable<Book> books) 
        { 
                var res = new List<BookResponseDTO>();

                foreach (var book in books)
                {
                    res.Add(new BookResponseDTO(book));
                }

                return res;
        }
        
    }
}
