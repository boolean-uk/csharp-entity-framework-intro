using exercise.webapi.Models.DTO;

namespace exercise.webapi.Repository
{
    public interface IPublisherRepository
    {
        public Task<GetPublisherDTO?> GetPublisherById(int id);
        public Task<IEnumerable<GetPublisherDTO>> GetAllPublishers();
    }
}
