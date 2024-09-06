using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IRepository<T>
    {
        public Task<IEnumerable<T>> GetAll();
        public Task<T> GetById(int id);
        public Task<T> GetByName(string name);
        public Task<T> GetByFullName(string firstName, string lastName);
        public Task<T> Add(T entity);
        public Task<T> Remove(T entity);
        public Task<T> Update(T entity);
    }
}
