using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class BookResponseDTO
    {

        public int Id { get; set; }
        public string Title { get; set; }

        public AuthorDTO Author { get; set; }
        //public ICollection<AuthorDTO> Authors { get; set; } = new List<AuthorDTO>();

        //extension
        public PublisherDTO Publisher { get; set; }
        //public ICollection<PublisherDTO> Publishers { get; set; } = new List<PublisherDTO>();

        public BookResponseDTO(Book book)
        {
            Id = book.Id;
            Title = book.Title;

            Author = new AuthorDTO(book.Author);
            //Authors = new List<AuthorDTO>();
            Publisher = new PublisherDTO(book.Publisher);   
            /*foreach (var author in book.authors)
            {
                
            }*/

        }

        public static List<BookResponseDTO> FromRepository(IEnumerable<Book> books)
        {
            var result = new List<BookResponseDTO>();
            foreach (var book in books)
            {
                result.Add(new BookResponseDTO(book));
            }

            return result;  
        }
    }
}
