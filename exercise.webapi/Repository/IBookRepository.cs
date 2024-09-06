using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetAll();
        public Task<Book> GetA(int id);
        public Task<Book> Update(Book book);
        public Task<Book> Delete(int id);
    }
}
