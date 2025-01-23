using exercise.webapi.DTOs;

namespace exercise.webapi.Repository
{
    public interface IAuthorRepository
    {
        public Task<IEnumerable<AuthorDTO>> GetAllAuthors();
        public Task<AuthorDTO> GetAuthorById(int id);
    }
}
