using exercise.webapi.Models;
using Microsoft.Extensions.Hosting;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetAllBooks();
        public Task<Book?> GetBook(int bookId);
        public Task<Book?> DeleteBook(int bookId);
        public Task<Book?> CreateBook(string title);
        public Task<Book?> UpdateBook(int BookId, string newTitle);
    }
}
