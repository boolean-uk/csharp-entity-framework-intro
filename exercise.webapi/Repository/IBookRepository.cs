using exercise.webapi.DTO;
using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetAllBooks();

        public Task<Book?> GetBook(int id);

        public Task<Book?> UpdateBook(int bookId, int authorId);

        public Task<Book?> DeleteBook(int id);

        public Task<Book?> AddBook(BookPost book);

    }
}
