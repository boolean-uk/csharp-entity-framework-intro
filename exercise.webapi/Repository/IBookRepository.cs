using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetAllBooks();

        Task <Book> GetBook(int id);
        Task <bool> DeleteBook(int id);
        Task <Book> AddBook(Book book);
        Task <Book> UpdateBook(int id, Book book);
    }
}
