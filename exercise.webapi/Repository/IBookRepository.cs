using exercise.webapi.Models;
using exercise.webapi.ViewModels;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetAllBooks();
        public Task<Book> GetSingleBook(int id);
        public Task<Book> UpdateBook(int bookId, int authorId);
        public Task<Book> DeleteBook(int id);
        public Task<Book> CreateBook(BookPostModel newBook);
    }
}
