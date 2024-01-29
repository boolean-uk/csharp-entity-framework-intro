using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetAllBooks();

        public Task<Book>? GetBook(int id);

        public Task<IEnumerable<Book>> DeleteBook(int id);

        public void SaveChanges();
    }
}