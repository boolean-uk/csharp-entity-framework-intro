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

    public async Task<Author> GetById(int id)
    {
        return (await db.Authors.FindAsync(id))!; 
    }

    public Task<Author> GetByName(string name)
    {
        throw new NotImplementedException();
    }
    
    public async Task<Author> GetByFullName(string firstName, string lastName)
    {
        return (await db.Authors.FirstOrDefaultAsync(a =>
            a.FirstName.ToLower() == firstName.ToLower() &&
            a.LastName.ToLower() == lastName.ToLower()))!; 
    }

    public async Task<Author> Add(Author entity)
    {
        db.Authors.Add(entity);
        await db.SaveChangesAsync();
        return entity;
    }

    public async Task<Author> Remove(Author entity)
    {
        db.Authors.Remove(entity);
        await db.SaveChangesAsync();
        return entity;
    }

    public async Task<Author> Update(Author entity)
    {
        var author = (await db.Authors.FindAsync(entity.Id))!;
        author.FirstName = entity.FirstName;
        author.LastName = entity.LastName;
        author.Email = entity.Email;
        await db.SaveChangesAsync();
        return author;
    }

    public List<Author> GetByPublisherId(int id)
    {
        throw new NotImplementedException();
    }
}