using System.ComponentModel.DataAnnotations.Schema;
using exercise.webapi.DTO;

namespace exercise.webapi.Models
{
    public class BookResponseDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        
        public AuthorDTO Author { get; set; }

        public BookResponseDTO(Book book)
        {
            Id = book.Id;
            Title = book.Title;

            Author = new AuthorDTO(book.Author);
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
