using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IAuthorRepository
    {
        Task<Author> GetAuthorByName(string FirstName, string LastName);

    }
}
