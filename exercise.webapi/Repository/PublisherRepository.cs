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
            return await _db.Publishers.Include(p => p.Books).ThenInclude(a => a.Author).ToListAsync();
        }

        public async Task<Publisher?> GetPublisher(int id)
        {
            return await _db.Publishers.Include(b => b.Books).ThenInclude(a => a.Author).FirstOrDefaultAsync(a => a.Id == id);
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}