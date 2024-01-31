using exercise.webapi.DTOs;
using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IAuthorRepository
    {
        public Task<ICollection<GetAuthorDTO>> GetAll();
        public Task<GetAuthorDTO> GetById(int id);
    }
}
