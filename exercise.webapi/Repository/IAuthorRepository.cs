using exercise.webapi.DTO;

namespace exercise.webapi.Repository
{
    public interface IAuthorRepository
    {
        public Task<IEnumerable<GetAuthorDto>> GetAllAuthors();

        public Task<GetAuthorDto> GetAuthor(int id);
    }
}
