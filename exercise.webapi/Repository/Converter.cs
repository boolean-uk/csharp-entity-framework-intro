using exercise.webapi.Models;
using exercise.webapi.Models.DTO;

namespace exercise.webapi.Repository
{
    public class Converter
    {
        public static BookDTO convertToBookDTO(Book book, Author author) 
        {
            AuthorDTO authorDTO = new AuthorDTO()
            {
                Id = author.Id,
                Email = author.Email,
                FirstName = author.FirstName,
                LastName = author.LastName
            };

            BookDTO bookDTO = new BookDTO()
            {
                Id = book.Id,
                Title = book.Title,
                AuthorId = book.AuthorId,
                Author = authorDTO
            };

            return bookDTO;
        }
    }
}
