using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IAuthorRepository
    {
        public Task<AuthorAndBooksDTO> GetAuthorById(int id);
        public Task<IEnumerable<AuthorAndBooksDTO>> GetAuthors();
    }
}
