using exercise.webapi.Models.InputTypes;
using exercise.webapi.Models.Types;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetAllBooks();
        public Task<Book?> GetBookById(int id);
        public Task<Book?> UpdateBook(int id, BookPost newBook);
        public Task<Book?> DeleteBook(int id);
        public Task<Book?> CreateBook(BookPost newBook);
        public Task<int> GetNewId();
    }
}
