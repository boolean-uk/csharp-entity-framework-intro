using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllBooks();
        Task<Author> GetAuthorById(int authorId);
        Task<Book> GetBookById(int id);
        Task SaveChanges();
        Task DeleteBook(Book book);
        Task AddBook(Book book);
    }
}
