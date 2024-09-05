using exercise.webapi.DTO;

namespace exercise.webapi.Repository
{
    public interface IPublisherRepository
    {
        
        public Task<IEnumerable<PublisherResponseDTO>> GetAllPublishers();
        public Task<PublisherResponseDTO> GetPublisher(int id);
        
    }
}