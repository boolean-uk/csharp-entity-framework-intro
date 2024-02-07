using exercise.webapi.Models;

namespace exercise.webapi.Repository.GenericRepository
{
    public interface IRepository<T> where T : class
    {
        Task<T> Insert(T entity);
        Task<IEnumerable<T>> Get();
        Task<T> Update(T entity);
        Task<T> Delete(object id);
        Task<T> GetById(object id);
    }
}
