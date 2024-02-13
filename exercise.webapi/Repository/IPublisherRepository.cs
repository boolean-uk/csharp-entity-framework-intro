using exercise.webapi.Models;
using exercise.webapi.Models.DTO;

namespace exercise.webapi.Repository
{
    public interface IPublisherRepository
    {
        Task<List<Publisher>> GetAll();
        Task<Publisher_DTO> Get(int id);
    }
}
