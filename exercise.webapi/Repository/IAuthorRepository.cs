using exercise.webapi.Models;
using exercise.webapi.Models.DatabaseModels;

namespace exercise.webapi.Repository
{
    public interface IAuthorRepository
    {
        public Task<IEnumerable<Author>> GetAllAuthors();
        public Task<Author> GetAAuthor(int id);
    }
}
