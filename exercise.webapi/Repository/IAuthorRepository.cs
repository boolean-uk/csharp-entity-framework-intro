using exercise.webapi.DTO;
using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IAuthorRepository
    {
        Task<IEnumerable<AuthorGetDTO>> GetAllAuthors();
        Task<AuthorGetDTO> GetAuthorById(int id);
    }
}
