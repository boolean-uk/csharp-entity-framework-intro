using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetAllBooks();
        public Task<Book> GetBook(int id);
        public Task<Book> PutAuthor(int id, int[] authorId);
        public void DeleteBook(int id);
        public Task<Book> CreateBook(Book book);
    }
}
