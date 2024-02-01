using exercise.webapi.Data;
using exercise.webapi.DTO;
using exercise.webapi.Models;

namespace exercise.webapi.Services
{
    public class Service
    {
        public BookDetailsDTO CreateBookDetailsDTO(Book book, Author author)
        {
            BookDetailsDTO bookDetailsDTO = new BookDetailsDTO();

            bookDetailsDTO.Id = book.Id;
            bookDetailsDTO.AuthorId = book.AuthorId;
            bookDetailsDTO.Title = book.Title;
            bookDetailsDTO.Author = author;

            return bookDetailsDTO;
        }

        public AuthorDTO CreateAuthorDTO(Author author, IEnumerable<Book> books, int authorID)
        {
            // Get all of the books based on the author ID
            AuthorDTO aDTO = new AuthorDTO();
            if (author == default(Author))
                return default(AuthorDTO);

            aDTO.Id = authorID;
            aDTO.FirstName = author.FirstName;
            aDTO.LastName = author.LastName;
            aDTO.Email = author.Email;
            aDTO.Books = books;

            return aDTO;
        }
    }
}
