using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IPublisherRepository
    {
        Task<Publisher> GetPublisher(int id);
        Task<IEnumerable<Publisher>> GetAllPublishers();
    }
}
