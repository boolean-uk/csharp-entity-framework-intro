using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetAllBooks();
        public Task<Book> GetBook(int id);
        public Task<Book> UpdateBook(int id, Author author);
        public Task DeleteBook(int id);  
        public Task<Book> CreateBook(Book book);
    }
}
