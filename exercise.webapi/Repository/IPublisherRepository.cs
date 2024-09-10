using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IPublisherRepository
    {
        Task<Publisher> GetA(int id);
        Task<IEnumerable<Publisher>> GetAll();
    }
}
