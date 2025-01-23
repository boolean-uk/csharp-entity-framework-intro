using exercise.webapi.Models;

namespace exercise.webapi.Repository;

public interface IAuthorRepository
{
    public Task<IEnumerable<Author>> GetAllAuthors();
    Task<Author?> GetAuthorById(int id);
}