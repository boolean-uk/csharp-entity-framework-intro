using exercise.webapi.DTO;
using System.ComponentModel.DataAnnotations.Schema;
using static exercise.webapi.DTO.BookDTO;


namespace exercise.webapi.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public BookDTO ToDTO()
        {
            AuthorDTO authorDTO = Author.ToDTO();
            return new BookDTO { Id = Id, Title = Title, Author = authorDTO };
        }

        public BookGet ToTDOResponse()
        {
            return new BookGet { Id = Id, Title = Title };
        }
    }
}
