using Microsoft.Extensions.Hosting;
using exercise.webapi.Models;

namespace exercise.webapi.DTOs
{
    public class BookDTO
    {

        public int Id { get; set; }
        public string Title { get; set; }

        public int AuthorID { get; set; }

        public ICollection<AuthorDTO> Authors { get; set; } = new List<AuthorDTO>(); 

        public BookDTO(Book book)
        {
            Id = book.Id;
            Title = book.Title;
            AuthorID = book.AuthorId;

            /*foreach (var bookAuthor in book.BookAuthors)
            {
                Authors.Add(new AuthorDTO(bookAuthor.Author));
            }*/

        }
    }
}


       