using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IRepository<T, TKey> where T : class
    {
        public Task<IEnumerable<T>> GetAll();
        public Task<T> Get(int id);

        public Task<T> Add(TKey entity);
        public Task<T> Update(int id, TKey entity);
        public Task<T> Delete(int id);
    }
}
