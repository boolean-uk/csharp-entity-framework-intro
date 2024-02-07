using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IAuthorRepo
    {
        public Task<IEnumerable<Author>> GetAllAuthors();
        public Task<Author> GetAuthorById(int id);
    }
}
