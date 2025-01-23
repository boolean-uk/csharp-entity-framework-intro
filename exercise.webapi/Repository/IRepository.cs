using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IRepository<T>
    {
        public void SaveRepository();

        public Task<IEnumerable<T>> GetAllEntities(); //Book
        public Task<T> GetEntityById(int id); //Book or Author

        public Task<bool> DeleteEntity(T entity);

    }
}
