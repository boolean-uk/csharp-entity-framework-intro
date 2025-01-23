using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookAuthorRepository
    {
        public Task<bool> DeleteBookAuthor(int id);
        public Task<BookAuthor> AddBookAuthor(BookAuthor bookAuthor);
    }
}
