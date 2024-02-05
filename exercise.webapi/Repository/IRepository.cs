using exercise.webapi.Models.DatabaseModels;

namespace exercise.webapi.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();

        Task<T?> Get(int id);

        Task<T> Update(int id, T entity);

        Task<T> Insert(T entity);

        Task<T> Delete(int id);

        Task<T> Delete(T entity);
    }
}
