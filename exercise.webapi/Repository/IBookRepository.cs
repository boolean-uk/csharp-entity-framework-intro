using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetAllBooks();
        public Task<Book> GetBook(int id);

        public Task<Book> DeleteBook(Book book);
        
        public Task<Book> CreateBook(Book book);

        public Task<Author> GetAuthor(int id);
    }
}
