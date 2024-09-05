using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetAllBooks();
        public Task<Book> GetBookById(int id);
        public Task<Book> UpdateBook(int id, BookPut model);
        public Task<Book> DeleteBook(int id);
        public Task<Book> CreateBook(BookPost model);
        Task<bool> AreAuthorsValid(List<int> authorIds);
    }
}
