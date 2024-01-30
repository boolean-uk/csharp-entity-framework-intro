using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IAuthorsRepository
    {
        public Task<IEnumerable<Author>> GetAllAuthors();

        public Task<Author?> GetAuthor(int authorId);

        public void SaveChanges();
    }
}
