using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IAuthorRepository
    {
        public Task<IEnumerable<Book>> GetAllAuthors();
        public Task<Author> GetAuthorById(int id);
    }
}
