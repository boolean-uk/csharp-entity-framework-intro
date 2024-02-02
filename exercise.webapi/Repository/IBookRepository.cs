using exercise.webapi.Models;
using exercise.webapi.Models.DatabaseModels;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetAllBooks();
        public Task<Book> GetABook(int id);
        public Task<Book> UpdateBook(int id, BookDto input);
        public Task<Book> CreateBook(Book input);
        public Task<Book> DeleteBook(int id);
    }
}
