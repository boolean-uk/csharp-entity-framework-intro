using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class PublisherRepository : IPublisherRepository
    {
        DataContext _db;

        public PublisherRepository(DataContext db)
        {
            _db = db;
        }
        public async Task<Publisher> GetPublisher(int id)
        {
            return await
                _db.Publishers.
                Include(p => p.Books).ThenInclude(b => b.Authors).
                ThenInclude(ba => ba.Author).
                    FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Publisher>> GetPublishers()
        {
            return await
                _db.Publishers.Include(p => p.Books).ThenInclude(b => b.Authors).
                ThenInclude(ba => ba.Author).ToListAsync();
        }
    }
}
