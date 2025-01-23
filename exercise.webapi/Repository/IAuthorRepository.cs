namespace exercise.webapi.Repository;

using exercise.webapi.Models;

public interface IAuthorRepository
{
    public Task<IEnumerable<Author>> GetAll();
    public Task<Author?> Get(int id);
}
