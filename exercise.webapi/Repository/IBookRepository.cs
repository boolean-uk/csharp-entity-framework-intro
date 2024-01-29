using System.Runtime.InteropServices;
using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetAllBooks();
        public Task<Book?> GetABook(int bookId);

        public Task<Book?> CreateBook(string title, Author author);

        public Task<Book?> DeleteBook(int bookid);
        public void SaveChanges();
    }
}
