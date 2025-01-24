using exercise.webapi.Data;
using exercise.webapi.DTO;
using exercise.webapi.Exceptions;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class AuthorRepository(DataContext db) : IRepository<Author>
    {
        private DataContext _db = db;

        public async Task<Author> Add(Author entity)
        {
            await _db.AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<Author> Delete(int id)
        {
            Author author = await Get(id);
            _db.Remove(author);
            await _db.SaveChangesAsync();
            return author;
        }

        public async Task<Author> Get(int id)
        {
            Author? author = await _db.Authors.Include(a => a.Books).ThenInclude(b => b.Publisher).SingleOrDefaultAsync(x => x.Id == id);
            if (author == null) throw new IdNotFoundException("The provided author Id does not exist!");
            return author;
        }

        public async Task<IEnumerable<Author>> GetAll()
        {
            return await _db.Authors.Include(a => a.Books).ThenInclude(b => b.Publisher).ToListAsync();
        }

        public async Task<Author> Update(Author entity)
        {
            if (_db.Entry(entity).State == EntityState.Detached)
            {
                _db.Authors.Attach(entity);
                _db.Entry(entity).State = EntityState.Modified;
            }

            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
