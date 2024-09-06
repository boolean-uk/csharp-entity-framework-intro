using exercise.webapi.Models;
using exercise.webapi.ViewModels;

namespace exercise.webapi.Repository
{
    public interface IAuthorRepository
    {
        public Task<List<AuthorResponse>> GetAllAuthors();
        public Task<AuthorResponse> GetAuthor(int id);
        public Task<AuthorResponse> AssignAuthor(int bookId, int authorId);
        public Task<AuthorResponse> RemoveAuthor(int bookId, int authorId);
    }
}
