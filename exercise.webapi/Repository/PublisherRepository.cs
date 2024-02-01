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
            var publishers = _db.Publishers.Include(p => p.Books).ThenInclude(b => b.Author);

            return await publishers.ToListAsync();
        }

        public async Task<Publisher> GetPublisher(int id)
        {
            var publisher = await _db.Publishers.Include(p => p.Books)
                                                      .ThenInclude(b => b.Author)
                                                      .FirstOrDefaultAsync(a => a.Id == id);
            return publisher;
        }
    }
}
