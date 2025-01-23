
using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IPublisherRepository
    {
        Task<PublisherAndBooksWithAuthorDTO> GetPublisher(int id);
        Task<IEnumerable<PublisherAndBooksWithAuthorDTO>> GetPublishers();
    }
}
