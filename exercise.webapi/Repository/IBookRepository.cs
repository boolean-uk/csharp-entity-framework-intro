using exercise.webapi.Models;

namespace exercise.webapi.Repository;

public interface IBookRepository
{
    public Task<IEnumerable<Book>> GetAllBooks();
    public Task<Book?> GetBook(int id);
    public Task<Book?> UpdateAuthor(int bookId, int authorId);
    public Task<bool> DeleteBook(int id);
    public Task<Book?> CreateBook(Book book);
}
