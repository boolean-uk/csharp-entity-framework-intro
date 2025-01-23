using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetAllBooks();
        public Task<Book> Get(int id);
        public Task<Book> Create(Book book);
        public Task<bool> Update(Book book);
        public Task<bool> Delete(Book book);
    }
}
