using exercise.webapi.DTO;

namespace exercise.webapi.Repository
{
    public interface IAuthorRepository
    {
        public Task<IEnumerable<AuthorResponseDTO>> GetAllAuthors();
        public Task<AuthorResponseDTO> GetAuthor(int id);
    }
}
