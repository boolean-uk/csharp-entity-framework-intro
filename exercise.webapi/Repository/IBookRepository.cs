using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public bool AuthorExists(int id);
        public Task<Book> CreateBook(BookPost bookPost);
        public Task<bool> DeleteBookById(int id);
        public Task<IEnumerable<Book>> GetAllBooks();
        public Task<Book> GetBookById(int id);
        public Task<Book> UpdateAuthorByBookId(int bookId, AuthorPut authorPut);
    }
}
