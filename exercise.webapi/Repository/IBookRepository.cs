using exercise.webapi.DTO_s;
using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetAllBooks();

        public Task<Book> GetBookByID(int id);

        public Task<Book> UpdateBook(int Id, int newID);
        public Task<Book> DeleteBook(int Id);

        public Task<Book> CreateBook(Book book);

    }
}
