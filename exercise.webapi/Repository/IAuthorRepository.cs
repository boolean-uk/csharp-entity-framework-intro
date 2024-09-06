using exercise.webapi.DTO;

namespace exercise.webapi.Repository
{
    public interface IAuthorRepository
    {
        public Task<IEnumerable<AuthorDTO>> GetAllAuthors();
        public Task<AuthorDTO> GetAuthor(int id);
    }
}
