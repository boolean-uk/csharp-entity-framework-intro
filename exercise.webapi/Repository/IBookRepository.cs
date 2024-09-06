using exercise.webapi.DTO;
using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        Task<Book> CreateABook(Book book);
        Task<Book> DeleteBook(int id);
        Task<IEnumerable<Book>> GetAllBooks();
        Task<Book> GetBook(int id);
        Task<Book> GetById(int id);
        Task<Book> UpdateById(int id, Book target);
    }
}
