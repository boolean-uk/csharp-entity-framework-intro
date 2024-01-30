using Microsoft.Extensions.Hosting;
using exercise.webapi.Models;
using System.Xml.Linq;

namespace exercise.webapi.DTO
{
    public class BookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public AuthorDTO Author { get; set; }
        public PublisherDTO Publisher { get; set; }

        public BookDTO(Book book)
        {
            Id = book.Id;
            Title = book.Title;
            Author = new AuthorDTO(book.Author);
            Publisher = new PublisherDTO(book.Publisher);
        }
    }
}