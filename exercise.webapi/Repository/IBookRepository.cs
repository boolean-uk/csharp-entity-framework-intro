using exercise.webapi.DTOs;
using exercise.webapi.DTOs.BookApi;
using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllBooks();
        Task<Book> GetABook(int id);
        Task<Book> UpdateBook(Book book);
        Task<Book> DeleteBook(int id);
        Task<Book> AddBook(BookPostModel bookmodel);
    }
}
