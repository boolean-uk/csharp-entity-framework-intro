using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IPublisherRepository
    {
        public Task<IEnumerable<Publisher>> GetPublishers();
        public Task<Publisher> GetAPublisher(int id);

    }
}
