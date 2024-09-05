using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository;

public class AuthorRepository(DataContext db) : IRepository<Author>
{
    public async Task<IEnumerable<Author>> GetAll()
    {
        return await db.Authors.ToListAsync();
    }

    public Task<Author> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Author> GetByName(string name)
    {
        throw new NotImplementedException();
    }

    public async Task<Author> Add(Author entity)
    {
        db.Authors.Add(entity);
        await db.SaveChangesAsync();
        return entity;
    }
}