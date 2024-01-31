using exercise.webapi.Models;

namespace exercise.webapi.Repository.AuthorRepo
{
    public interface IAuthorRepository
    {
        public Task<Author?> GetByIdAsync(int id);

        public Task<IEnumerable<Author>> GetAllAsync();
    }
}
