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

        public async Task<IEnumerable<Publisher>> GetAllPublishers()
        {
            return await _db.Publisher.Include(p => p.Books).ThenInclude(p => p.Author).ToListAsync();
        }
        public async Task<Publisher?> GetPublisher(int id)
        {
            return await _db.Publisher.Include(p => p.Books).ThenInclude(p => p.Author).SingleOrDefaultAsync(p => p.Id == id);
        }
    }
}
