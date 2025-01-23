using exercise.webapi.DTO;

namespace exercise.webapi.Repository
{
    public interface IPublisherRepository
    {
        Task<IEnumerable<PublisherGetDTO>> GetAllPublishers();
        Task<PublisherGetDTO> GetPublisherById(int id);
    }

}
