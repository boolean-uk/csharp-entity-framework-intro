using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository;

public class PublisherRepository(DataContext db) : IRepository<Publisher>
{
    public async Task<IEnumerable<Publisher>> GetAll()
    {
        return await db.Publishers.ToListAsync();
    }

    public Task<Publisher> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Publisher> GetByName(string name)
    {
        throw new NotImplementedException();
    }

    public async Task<Publisher> Add(Publisher entity)
    {
        db.Publishers.Add(entity);
        await db.SaveChangesAsync();
        return entity;
    }
}