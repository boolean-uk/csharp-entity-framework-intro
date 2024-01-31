using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<BookDTO>> GetAllBooks();
        public Task<BookDTO?> GetBookById(int id);
        public Task<BookDTO?> UpdateBook(int id, BookPost newBook);
        public Task<BookDTO?> DeleteBook(int id);
        public Task<BookDTO?> CreateBook(BookPost newBook);
        public Task<int> GetNewId();
    }
}
