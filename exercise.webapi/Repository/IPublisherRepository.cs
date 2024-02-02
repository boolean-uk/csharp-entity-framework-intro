using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IPublisherRepository
    {

        public Task<Publisher> GetPublisherById(int id);

        public Task<List<Publisher>> GetPublishers();
    }
}
