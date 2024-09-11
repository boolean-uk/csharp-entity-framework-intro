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

        public async Task<List<Publisher>> GetAllPublishers()
        {
            return await _db.Publishers.Include(p => p.Books).ToListAsync();
        }

        public async Task<Publisher> GetPublisherById(int id)
        {
            return await _db.Publishers.FirstOrDefaultAsync(a => a.Id == id);
        }
    }
}
