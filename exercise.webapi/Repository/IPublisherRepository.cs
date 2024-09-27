using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IPublisherRepository
    {
        public Task<Publisher> GetAPublisher(int? id);
        public Task<IEnumerable<Publisher>> getPublisher();
    }
}
