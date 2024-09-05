using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IRepository<T>
    {
        public Task<IEnumerable<T>> GetAll();
        public Task<T> GetById(int id);
        public Task<T> GetByName(string name);
        public Task<T> Add(T entity);
    }
}
