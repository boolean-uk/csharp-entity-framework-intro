using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IAuthorRepository
    {
        public Task<List<Author>> GetAuthors();
        public Task<Author> GetAuthor(int id);
    }
}
