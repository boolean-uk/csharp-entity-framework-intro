using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {

        public Task<IEnumerable<Book>> GetAllBooks();
        public Task<Book?> GetBook(int bookId);

        public Task<Book> AddBook(Book book);

        public Task<Book?> DeleteBook(int bookId);

        public void SaveChanges();
    }
}
