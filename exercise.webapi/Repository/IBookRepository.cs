using exercise.webapi.DTO;
using exercise.webapi.DTOS;
using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<Book> CreateBook(Book entity);
        public Task<Book> DeleteBookById(int id);
        public Task<IEnumerable<Book>> GetAllBooks();
        public Task<Book> GetBookById(int id);
        public Task<Book> UpdateBookById(int id, Book entity);
    }
}
