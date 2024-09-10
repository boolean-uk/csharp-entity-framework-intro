using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetAllBooks();

        public Task<Book> GetById(int id);

        public Task<Book> Add(Book entity);

        public Task<Book> DeleteById(int id);
    }
}
