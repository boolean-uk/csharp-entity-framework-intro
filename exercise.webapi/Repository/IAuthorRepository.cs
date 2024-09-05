using exercise.webapi.Models;
using exercise.webapi.ViewModels;

namespace exercise.webapi.Repository
{
    public interface IAuthorRepository
    {
        public Task<List<Author>> GetAllAuthors();
        public Task<Author> GetAuthor(int id);
    }
}
