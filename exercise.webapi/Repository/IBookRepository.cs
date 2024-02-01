using exercise.webapi.Data;
using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<Tuple<Book, Author>> GetBook(int id);
        public Task<Tuple<IEnumerable<Book>, IEnumerable<Author>>> GetAllBooks();
        public Task<Tuple<Book, Author>> UpdateBook(int bookID, int newAuthorID);
        public Task<Book> DeleteBook(int id);
        public Task<Tuple<Book,Author>> CreateBook(Book book);
        public DataContext GetDatabase();
    }
}
