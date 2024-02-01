
using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IPublisherRepository
    {
        Task<IEnumerable<Publisher>> GetPublishers();
    }
}
