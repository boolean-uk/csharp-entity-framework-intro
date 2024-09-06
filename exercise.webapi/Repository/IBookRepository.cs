using exercise.webapi.DTO;
using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<BookDTO>> GetAllBooks();
        public Task<BookDTO> GetBook(int id);
        public Task<BookDTO> UpdateBook(BookDTO newBook,int id);
        public Task<Book> DeleteBook(int id);
        public Task<BookDTO> CreateBook(BookDTO book);
    }
}
