using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IPublisherRepository
    {
        PublisherDTO GetPublisher(int id);
        Task<IEnumerable<PublisherDTO>> GetAll();
    }
}
