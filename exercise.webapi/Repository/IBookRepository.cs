using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetAllBooks();
        public Task<Book?> GetBook(int id);

        public Task<Book?> AddBook(CreateBookPayload payload);

        public Task<Book?> UpdateBook(int id, UpdateBookPayload payload);

        public Task<bool> DeleteBook(int id);
    }
}
