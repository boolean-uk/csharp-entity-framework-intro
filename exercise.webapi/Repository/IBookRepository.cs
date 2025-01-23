using exercise.webapi.DTO;
using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetAllBooks();
        public Task<Book> GetBook(int id);
        public Task<Book> UpdateBook(int id, Author Author);
        public Task<Book> DeleteBook(int id);
        public Task<Book> CreateBook(string Title, int AuthorId, Author Author);
    }
}
