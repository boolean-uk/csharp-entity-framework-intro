using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IAuthorRepository
    {
        public Task<Author?> GetAuthorById(int id);
    }
}
