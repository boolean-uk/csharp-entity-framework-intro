using exercise.webapi.Data;
using exercise.webapi.Models.DatabaseModels;
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
            return await _db.Publisher.Include(p => p.Books).ThenInclude(b=>b.Author).ToListAsync();
        }

        public async Task<Publisher> GetAPublsiher(int id)
        {
            return await _db.Publisher.Include(p=>p.Books).ThenInclude(b=>b.Author).FirstAsync(p=>p.Id == id);
        }
    }
}
