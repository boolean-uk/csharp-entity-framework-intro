using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<List<Book>> GetAllBooks();
        Task<Book> GetBookById(int id);
        Task<Book> UpdateBookAuthor(int bookId, int authorId);
        Task<Book> CreateBook(Book book);
        Task<Book> DeleteBook(int id);
        
    }
}
