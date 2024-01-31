using System.ComponentModel.DataAnnotations.Schema;
using exercise.webapi.DTO;

namespace exercise.webapi.Models
{
    public class BookResponseDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public PublisherDTO Publisher { get; set; }
        public ICollection<AuthorDTO> Authors { get; set; }

        public BookResponseDTO(Book book)
        {
            Id = book.Id;
            Title = book.Title;
            Publisher = new PublisherDTO(book.Publisher);
            Authors = book.AuthorBooks.Select(ab => new AuthorDTO(ab.Author)).ToList();
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