using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IAuthorRepository
    {
        Task<IEnumerable<Author>> GetAllAuthors ();
        Task<Author> GetAuthorByName(string FirstName, string LastName);
        Task<Author> GetAuthorById(int id);

    }
}
