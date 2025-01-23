using exercise.webapi.DTO;
using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetAllBooks();

        Task<Book> GetBook(int id);
        Task<bool> DeleteBook(int id);
        Task<Book> AddBook(Book Book);
        Task<Book> UpdateBook(Book Book);
        Task<Book> RemoveAuthor(int id);
        Task<Book> AssignAuthor(int id, int authId);

    }
}
