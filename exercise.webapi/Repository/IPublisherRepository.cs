namespace exercise.webapi.Repository;

using exercise.webapi.Models;

public interface IPublisherRepository
{
    public Task<IEnumerable<Publisher>> GetAll();
    public Task<Publisher?> Get(int id);
}
