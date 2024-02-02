using exercise.webapi.Data;
using exercise.webapi.DTO_s;
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
        public async Task<Publisher> GetAPublisher(int id)
        {
            return await _db.Publishers
                .Include(b => b.Books)
                .ThenInclude(a => a.Author)
                .FirstAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Publisher>> GetPublishers()
        {
            return await _db.Publishers
                .Include(b => b.Books)
                .ThenInclude(a => a.Author)
                .ToListAsync();

        }
    }
}
