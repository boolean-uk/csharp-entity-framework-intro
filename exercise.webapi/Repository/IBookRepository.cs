using exercise.webapi.Models;
using exercise.webapi.ViewModels;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<BookResponse>> GetAllBooks();
        public Task<BookResponse> GetBook(int id);
        public Task<BookResponse> UpdateBook(int bookId, int authorId);
        public Task<BookResponse> DeleteBook(int id);
        public Task<BookResponse> AddBook(Book entity);
    }
}
