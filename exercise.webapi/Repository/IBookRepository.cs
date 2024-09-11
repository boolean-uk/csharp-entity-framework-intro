using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<List<Book>> GetAllBooks();

        public Task<Book> GetBookById(int id);

        public Task<Book> UpdateBookAuthorById(Book entity, int id);

        public Task<Book> DeleteBookById(int id);
        public Task<Book> AddBook(Book entity);
    }
}
