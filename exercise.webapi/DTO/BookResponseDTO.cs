using exercise.webapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.DTO
{
    public class BookResponseDTO
    {

        public int Id { get; set; }
        public string Title { get; set; }

        public AuthorDTO Author { get; set; }
        public ICollection<AuthorDTO> Authors { get; set; } = new List<AuthorDTO>();
        //extension
        public PublisherDTO Publisher { get; set; }

        public BookResponseDTO(Book book)
        {
            Id = book.Id;
            Title = book.Title;

            // Have in mind to remove then many-to-many relation is implemented
            Author = new AuthorDTO(book.Author);
            Publisher = new PublisherDTO(book.Publisher); 
            
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
