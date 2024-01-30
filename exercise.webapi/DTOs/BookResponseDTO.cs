using exercise.webapi.DTOs;
using exercise.webapi.Models;
using Microsoft.Extensions.Hosting;

namespace exercise.webapi.DTOs
{
    public class BookResponseDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public AuthorDTO Author { get; set; }
        public ICollection<AuthorDTO> Authors { get; set; }

        public BookResponseDTO(Book book, bool includeAuthors = false)
        {
            Id = book.Id;
            Title = book.Title;

            Author = new AuthorDTO(book.Author);
            /*
            if (includeAuthors)
            {
                Authors = book.BookAuthors.Select(ba => new AuthorDTO(ba.Author)).ToList();
            }*/
        }


        
        public static List<BookResponseDTO> FromRepository(IEnumerable<Book> books)
        {
            var results = new List<BookResponseDTO>();
            foreach (var book in books)
            {
                results.Add(new BookResponseDTO(book));

            }
            return results;
        }
        /*
        public static List<BookResponseDTO> FromRepository(IEnumerable<Book> books, bool includeAuthors = false)
        {
            var results = new List<BookResponseDTO>();
            foreach (var book in books)
            {
                results.Add(new BookResponseDTO(book, includeAuthors));
            }
            return results;
        }*/
    }
}



     