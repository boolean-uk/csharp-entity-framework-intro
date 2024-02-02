using exercise.webapi.Models.DatabaseModels;

namespace exercise.webapi.Repository
{
    public interface IPublisherRepository
    {
        public Task<IEnumerable<Publisher>> GetAllPublishers();
        public Task<Publisher> GetAPublsiher(int id);
    }
}
