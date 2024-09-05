using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class PublisherRepo
    {
        DataContext _db;

        public PublisherRepo(DataContext db) {  _db = db; }

        public async Task<IEnumerable<Publisher>> GetPublishers()
        {
            return await _db.Publishers
                .Include(p => p.Publishedbooks)
                .ThenInclude(b => b.Bookauthors)
                .ThenInclude(a => a.Author)
                .ToListAsync();
        }

        public async Task<Publisher> GetAPublisher(int id)
        {
            return await _db.Publishers
                .Include(p => p.Publishedbooks)
                .ThenInclude(b => b.Bookauthors)
                .ThenInclude(a => a.Author)
                .FirstAsync(x => x.Id == id);
        }

    }
}
