using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IAuthorRepository
    {
        Task<AuthorDTO> GetAuthor(int id);
        Task<IEnumerable<AuthorDTO>> GetAll();
    }
}
