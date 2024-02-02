using exercise.webapi.Models.BaseModels;

namespace exercise.webapi.Repository
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(object id);
        Task<T> Insert(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(object id);
        Task<bool> IsAnExistingID(object id);
    }
}
