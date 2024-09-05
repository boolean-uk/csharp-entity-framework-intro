using exercise.webapi.DTO;

namespace exercise.webapi.Repository
{
    public interface IAuthorRepository
    {
        public Task<IEnumerable<AuthorGetModel>> GetAllAuthors();
        public Task<AuthorGetModel> GetAuthor(int id);
    }
}
