using exercise.webapi.Models.DTO;

namespace exercise.webapi.Repository
{
    public interface IAuthorRepository
    {
        public Task<GetAuthorDTO?> GetAuthorById(int id);
        public Task<IEnumerable<GetAuthorDTO>> GetAllAuthors();
    }
}
