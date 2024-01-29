using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class BookResponseDTO
    {

        public int Id { get; set; }
        public string Title { get; set; }

        public AuthorDTO Author { get; set; }
        public ICollection<AuthorDTO> Authors { get; set; } = new List<AuthorDTO>();

        public BookResponseDTO(Book book)
        {
            Id = book.Id;
            Title = book.Title;

            Author = new AuthorDTO(book.Author);
            Authors = new List<AuthorDTO>();
           
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
