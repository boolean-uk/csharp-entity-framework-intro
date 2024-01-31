using exercise.webapi.Models;
using System.Collections.Generic;
namespace exercise.webapi.DTO
{
    public class BookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<AuthorDTO> AuthorsToBook { get; set; } = new List<AuthorDTO>();

        public BookDTO(Book book, int callingAuthorId)
        {
            Id = book.Id;
            Title = book.Title;

            AuthorsToBook = book.AuthorBooks.Select(ab => new AuthorDTO(ab.Author)).ToList();
        }

        public BookDTO(Book book)
        {
            Id = book.Id;
            Title = book.Title;

            AuthorsToBook = book.AuthorBooks.Select(ab => new AuthorDTO(ab.Author)).ToList();
        }

    }
}