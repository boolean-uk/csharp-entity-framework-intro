using exercise.webapi.Models;
using Microsoft.Extensions.Hosting;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetAllBooks();
        //public Task<IEnumerable<Book>> GetAllBooks(bool includeAuthors = false);
        public Task<Book?> GetBook(int bookId);
        //public Task<Book?> GetBook(int bookId, bool includeAuthors = false);
        public Task<Book?> DeleteBook(int bookId);
        public Task AddBook(Book book);
        public void SaveChanges();
    }
}
