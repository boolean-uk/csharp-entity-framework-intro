using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IAuthorRepository
    {
        public Task<IEnumerable<Tuple<Author, IEnumerable<Book>>>> GetAllAuthorBooks();
        public Tuple<Author, IEnumerable<Book>> GetAuthorBooks(int authorID);
    }
}
