using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<Book> GetABook(string title);
        public Task<IEnumerable<Book>> GetAllBooks();
    }
}
