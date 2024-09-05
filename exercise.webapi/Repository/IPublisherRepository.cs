using exercise.webapi.DTO;

namespace exercise.webapi.Repository
{
    public interface IPublisherRepository
    {
        public Task<IEnumerable<PublisherGetModel>> GetAllPublishers();
        public Task<PublisherGetModel> GetPublisher(int id);
    }
}
