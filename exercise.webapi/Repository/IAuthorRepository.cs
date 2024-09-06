using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IAuthorRepository
    {
        public Task<Author> GetSingleAuthor(int id);
        public Task<IEnumerable<Author>> GetAuthors();
    }
}
