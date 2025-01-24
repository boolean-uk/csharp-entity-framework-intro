using exercise.webapi.Data;
using exercise.webapi.DTO;
using exercise.webapi.Exceptions;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class PublisherRepository(DataContext db) : IRepository<Publisher>
    {
        DataContext _db = db;

        public async Task<Publisher> Add(Publisher entity)
        {
            await _db.Publishers.AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<Publisher> Delete(int id)
        {
            Publisher publisher = await Get(id);
            _db.Publishers.Remove(publisher);
            await _db.SaveChangesAsync();
            return publisher;
        }

        public async Task<Publisher> Get(int id)
        {
            Publisher? publisher = await _db.Publishers.Include(b => b.Books).ThenInclude(book => book.Authors).SingleOrDefaultAsync(x => x.Id == id);
            if (publisher == null) throw new IdNotFoundException("The provided publisher Id does not exist!");
            return publisher;
        }

        public async Task<IEnumerable<Publisher>> GetAll()
        {
            return await _db.Publishers.Include(publisher => publisher.Books).ThenInclude(book => book.Authors).ToListAsync();
        }

        public async Task<Publisher> Update(Publisher entity)
        {
            if (_db.Entry(entity).State == EntityState.Detached)
            {
                _db.Publishers.Attach(entity);
                _db.Entry(entity).State = EntityState.Modified;
            }

            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
