using exercise.webapi.DTO;
using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetAllBooks();

        public Task<Book> GetBook(int id);

        public Task<Book> UpdateBook(int id, int newAuthorId);

        public Task DeleteBook(int id);

        Task<Author> GetAuthor(int id);

        public Task<Book> createBook(BookDTO book);

        Task<Book> RemoveAuthor(int bookId);

        Task<Book> AssignAuthor(int bookId, int authorId);

    }
}
