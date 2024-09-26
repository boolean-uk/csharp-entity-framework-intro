using exercise.webapi.Data;
using exercise.webapi.Models.BaseModels;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class PublisherRepository : IRepository<Publisher>
    {
        DataContext _db;

        public PublisherRepository(DataContext db)
        {
            _db = db;
        }

        public Task<Publisher> Delete(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<Publisher> Get(object id)
        {
            return await _db.Publishers.Include(p => p.Books).ThenInclude(b => b.Author).FirstOrDefaultAsync(p => p.ID == (int)id);
        }

        public async Task<IEnumerable<Publisher>> GetAll()
        {
            return await _db.Publishers.Include(p => p.Books).ThenInclude(b => b.Author).ToListAsync();
        }

        public Task<Publisher> Insert(Publisher entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsAnExistingID(object id)
        {
            throw new NotImplementedException();
        }

        public Task<Publisher> Update(Publisher entity)
        {
            throw new NotImplementedException();
        }
    }
}
