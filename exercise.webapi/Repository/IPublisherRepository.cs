using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IPublisherRepository
    {
        public Task<IEnumerable<Publisher>> GetAllPublishers();
        public Task<Publisher> GetById(int id);
    }
}
