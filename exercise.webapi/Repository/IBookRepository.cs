using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllBooks();

        Task<Book> GetBookById(int id);

        Task<Book> UpdateById(int id, Book entity);
        Task <Book> DeleteById(int id);
    }
}
