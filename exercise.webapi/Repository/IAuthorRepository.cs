using exercise.webapi.Models;
using exercise.webapi.ViewModels;

namespace exercise.webapi.Repository
{
    public interface IAuthorRepository
    {
        public Task<List<AuthorResponse>> GetAllAuthors();
        public Task<AuthorResponse> GetAuthor(int id);
    }
}
