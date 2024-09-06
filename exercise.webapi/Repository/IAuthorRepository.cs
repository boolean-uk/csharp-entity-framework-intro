using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IAuthorRepository
    {
        public Task<IEnumerable<Author>> GetAll();
        public Task<Author> GetA(int id);
        public Task<Author> Update(Author author);

    }
}
