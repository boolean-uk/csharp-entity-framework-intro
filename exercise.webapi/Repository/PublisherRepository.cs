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

    public async Task<Publisher> GetById(int id)
    {
        return (await db.Publishers.FindAsync(id))!; 
    }

    public async Task<Publisher> GetByName(string name)
    {
        return (await db.Publishers.FirstOrDefaultAsync(p => 
            p.Name.ToLower( )== name.ToLower()))!;
    }
    
    public Task<Publisher> GetByFullName(string firstName, string lastName)
    {
        throw new NotImplementedException();
    }

    public async Task<Publisher> Add(Publisher entity)
    {
        db.Publishers.Add(entity);
        await db.SaveChangesAsync();
        return entity;
    }

    public async Task<Publisher> Remove(Publisher entity)
    {
        db.Publishers.Remove(entity);
        await db.SaveChangesAsync();
        return entity;
    }

    public async Task<Publisher> Update(Publisher entity)
    {
        var publisher = (await db.Publishers.FindAsync(entity.Id))!;
        publisher.Name = entity.Name;
        await db.SaveChangesAsync();
        return publisher;
    }

    public List<Publisher> GetByPublisherId(int id)
    {
        throw new NotImplementedException();
    }
}