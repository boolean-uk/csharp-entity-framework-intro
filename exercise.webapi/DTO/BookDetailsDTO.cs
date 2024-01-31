using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class BookDetailsDTO
    {
       
            public int tmpId { get; set; }
            public string tmpTitle { get; set; }
            public ICollection<AuthorDTO> Authors { get; set; } = new List<AuthorDTO>();
            public PublisherDTO Publisher { get; set; }

            public BookDetailsDTO(Book book)
            {
                tmpId = book.Id;
                tmpTitle = book.Title;
                Authors = book.BookAuthors.Select(ba => new AuthorDTO(ba.Author)).ToList();
                Publisher = new PublisherDTO(book.Publisher);
            }

            public static List<BookDetailsDTO> FromRepository(IEnumerable<Book> books)
            {
                return books.Select(book => new BookDetailsDTO(book)).ToList();
            }
        
    }
}
