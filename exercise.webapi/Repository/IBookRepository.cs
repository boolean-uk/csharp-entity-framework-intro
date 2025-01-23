using exercise.webapi.DTO;
using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        Task<IEnumerable<BookGetDTO>> GetAllBooks();
        Task<BookGetDTO> GetBookById(int id);
        Task<Book?> GetBookByIdAsModel(int id);
        Task<Book> AddBook(Book book);
        Task<Book> UpdateBook(int id, Book book);
        Task<bool> DeleteBook(int id);
    }
}
