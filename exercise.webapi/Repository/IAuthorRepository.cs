using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IAuthorRepository
    {
        public Task<IEnumerable<AuthorDTO>> GetAllAuthors();
        public Task<AuthorDTO> GetAuthor(int id);
    }
}
