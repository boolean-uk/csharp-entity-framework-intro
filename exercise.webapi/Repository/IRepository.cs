using exercise.webapi.Models.DatabaseModels;

namespace exercise.webapi.Repository
{
    public interface IRepository<T,S> where T : class where S: class
    {
        Task<IEnumerable<T>> GetAllT();

        Task<T?> Get(int id);

        Task<T> Update(int id, T entity);

        Task<T> Insert(T entity);

        Task<IEnumerable<S>> GetAllS();

        Task<T> Delete(int id);
    }
}
