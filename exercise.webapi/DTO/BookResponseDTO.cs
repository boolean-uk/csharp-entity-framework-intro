using System.ComponentModel.DataAnnotations.Schema;
using exercise.webapi.DTO;

namespace exercise.webapi.Models
{
    public class BookResponseDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public PublisherDTO Publisher { get; set; }
        public ICollection<AuthorDTO> Authors { get; set; } = new List<AuthorDTO>();

        public BookResponseDTO(Book book)
        {
            Id = book.Id;
            Title = book.Title;
            Publisher = new PublisherDTO(book.Publisher);
            foreach (var author in book.Authors)
            {
                Authors.Add(new AuthorDTO(author));
            }
        }

        public static List<BookResponseDTO> FromRepository(IEnumerable<Book> books){
            var results = new List<BookResponseDTO>();
            foreach (var book in books)
            {
                results.Add(new BookResponseDTO(book));
            }
            return results;
        }

        public static BookResponseDTO FromRepository(Book Book){
            return new BookResponseDTO(Book);
        }

    }
}
