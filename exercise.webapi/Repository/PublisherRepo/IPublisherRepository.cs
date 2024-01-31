using exercise.webapi.Models;

namespace exercise.webapi.Repository.PublisherRepo
{
    public interface IPublisherRepository
    {
        public Task<Publisher?> GetByIdAsync(int publisherId);
        public Task<IEnumerable<Publisher>> GetAllAsync();
    }
}
