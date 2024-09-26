using exercise.webapi.Models;
using exercise.webapi.Models.Payload;

namespace exercise.webapi.Repository.BookRepo
{
    public interface IBookRepository
    {
        public Task<Book?> GetByIdAsync(int id);

        public Task<IEnumerable<Book>> GetAllBooksAsync();

        public Task<Book> UpdateBookByIDAsync(int id, int authorID);

        public Task<bool> DeleteABook(int bookID);

        public Task<Book> CreateABook(BookPayload payload);
    }
}
