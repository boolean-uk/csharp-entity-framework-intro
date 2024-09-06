using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetAllBooks();
        public Task<Book> GetById(int id);
        public Task<Book> UpdateById(int id, int authorId);
        public Task<string> DeleteById(int id);
        public Task<Book> Create(Book book);
        public Task<bool> ContainsAuthor(int id);
        public Task<bool> ContainsBook(int id);
    }
}
