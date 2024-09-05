using exercise.webapi.Models;
using exercise.webapi.ViewModels;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetAllBooks();
        public Task<Book> GetBook(int id);
        public Task<Book> UpdateBook(int id, Book entity);
        public Task<Book> DeleteBook(int id);
        public Task<Book> AddBook(Book entity);
    }
}
