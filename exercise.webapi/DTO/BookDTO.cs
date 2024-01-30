using exercise.webapi.Models;
using System.Collections.Generic;
namespace exercise.webapi.DTO
{
    public class BookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<AuthorDTO> CoAuthors { get; set; } = new List<AuthorDTO>();

        public BookDTO(Book book, int callingAuthorId)
        {
            Id = book.Id;
            Title = book.Title;

            foreach (var author in book.Authors)
            {
                if (author.Id == callingAuthorId)
                {
                    continue;
                }
                CoAuthors.Add(new AuthorDTO(author));
            }
        }

        public BookDTO(Book book)
        {
            Id = book.Id;
            Title = book.Title;

            foreach (var author in book.Authors)
            {      
                CoAuthors.Add(new AuthorDTO(author));
            }
        }

    }
}