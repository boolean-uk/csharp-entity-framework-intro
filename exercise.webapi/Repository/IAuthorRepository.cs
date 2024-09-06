using exercise.webapi.DTO;

namespace exercise.webapi.Repository
{
    public interface IAuthorRepository
    {
        public Task<List<DTOAuthor>> GetAuthors();

        public Task<DTOAuthor> GetAuthor(int id);
    }
}
