using exercise.webapi.Models.InputTypes;
using exercise.webapi.Models.Types;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetAllBooks();
        public Task<Book?> GetBookById(int id);
        public Task<Book?> UpdateBook(int id, BookPut newBook);
        public Task<Book?> DeleteBook(int id);
        public Task<Book?> CreateBook(BookPost newBook);
        public Task<int> GetNewId();
        public Task<Book?> AddAuthorToBook(Book book, int authorId);
        public Task<Book?> RemoveAuthorFromBook(Book book, int authorId);
    }
}
