using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IAuthorRepository
    {
        Task<List<Author>> GetAllAuthors();

        Task<Author> GetAuthorById(int id);

    }

}
