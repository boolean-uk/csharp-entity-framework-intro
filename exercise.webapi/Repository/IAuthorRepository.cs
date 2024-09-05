using exercise.webapi.DTO;
using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IAuthorRepository
    {
        public Task<ResponseAuthorDTO> GetAuthor(int id);
        public Task<IEnumerable<ResponseAuthorDTO>> GetAll();
    }
}
