using exercise.webapi.DTOs;

namespace exercise.webapi.Repository
{
    public interface IPublisherRepository
    {
        public Task<ICollection<GetPublisherDTO>> GetAll();
        public Task<GetPublisherDTO> GetById(int id);
    }
}
