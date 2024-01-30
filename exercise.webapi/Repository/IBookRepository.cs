using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetAllBooks();

        public Task<Book?> GetBookbyId(int id);
        public Task<Book?> UpdateBook(int id, int authorId);

        public Task<bool> DeleteBook(int id);
        public Task<Book> CreateBook(BookPostPayload data);
    }
}
