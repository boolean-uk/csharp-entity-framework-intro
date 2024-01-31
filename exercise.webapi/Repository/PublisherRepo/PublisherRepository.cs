using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository.PublisherRepo
{
    public class PublisherRepository : IPublisherRepository
    {
        private DataContext _db;

        public PublisherRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<Publisher?> GetByIdAsync(int publisherId)
        {
            return await _db.Publishers.Include(p => p.Books).ThenInclude(p => p.Author).FirstOrDefaultAsync(p => p.Id.Equals(publisherId));
        }

        public async Task<IEnumerable<Publisher>> GetAllAsync()
        {
            return await _db.Publishers.Include(p => p.Books).ThenInclude(b => b.Author).ToListAsync();
        }
    }
}
