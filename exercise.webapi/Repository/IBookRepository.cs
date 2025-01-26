using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetAllBooks();
        Task<Book> Get(int id);
        Task<bool> Delete(int id);
        Task<Book> Add(Book book);
        Task<Book> Update(int authorid, int bookid);

    }
}
