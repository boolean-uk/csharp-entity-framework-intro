using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookAuthorRepository
    {
        public Task<Book> CreateRelation(int bookId, int authorId);

        public Task<BookAuthor> GetRelation(int authorId, int bookId);

        public Task<Book> DeleteRelation(BookAuthor relation);
    }
}
