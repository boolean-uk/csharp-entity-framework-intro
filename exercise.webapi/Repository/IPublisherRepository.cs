using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IPublisherRepository
    {
        public Task<List<Publisher>> GetAllPublishers();
        public Task<PublisherDto> GetPublisher(int id);
    }
}
