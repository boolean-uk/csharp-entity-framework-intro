using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetAllBooks();
        public Task<Book?> GetBook(int id);
        public Task<Book?> DeleteBook(int id);
        public void SaveChanges();
        public Task<Book?> CreateBook(int bookId, int authorId, Author author, string title);
    }
}
