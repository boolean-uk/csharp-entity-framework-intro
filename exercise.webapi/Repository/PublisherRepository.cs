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
            var publishers = _db.Publishers.Include(b => b.Books).ThenInclude(a => a.Author);
            return await publishers.ToListAsync();
        }

        public async Task<Publisher> GetById(int id)
        {
            var publisher = await _db.Publishers.Include(b => b.Books).ThenInclude(a => a.Author)
                .FirstOrDefaultAsync(p => p.Id == id);
            return publisher;
        }
    }
}
