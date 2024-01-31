using System.ComponentModel.DataAnnotations.Schema;
using exercise.webapi.Models.DTO;

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

        public BookResponseTDO ToTDOResponse()
        {
            return new BookResponseTDO { Id = Id, Title = Title };
        }
    }
}
