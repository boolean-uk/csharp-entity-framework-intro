using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IPublisherRepo
    {
        public Task<IEnumerable<Publisher>> GetPublishers();
        public Task<Publisher> GetAPublisher(int id);
    }
}
