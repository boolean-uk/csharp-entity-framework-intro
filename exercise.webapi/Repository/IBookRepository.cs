using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Payload;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<Payload<IEnumerable<BookDTO>>> GetAllBooks();
        public Task<Payload<BookDTO>> GetBook(int id);
        public Task<Payload<BookDTO>> UpdateAuthor(int bookId, AuthorPostDTO authorPost);
        public Task<Payload<BookDTO>> DeleteBook(int id);
        public Task<Payload<BookDTO>> CreateBook(CreateBookDTO bookDTO);
    }
}
