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
            return await _db.Publishers
                .Include(p => p.PublishedBooks)
                .ThenInclude(b => b.BookAuthors)
                .ThenInclude(ba => ba.Author)
                .ToListAsync();
        }

        public async Task<Publisher> GetAPublisher(int id)
        {
            return await _db.Publishers.
                Include(p => p.PublishedBooks)
                .ThenInclude(b => b.BookAuthors)
                .ThenInclude(ba => ba.Author)
                .FirstAsync(p => p.Id == id);
        }
    }
}
