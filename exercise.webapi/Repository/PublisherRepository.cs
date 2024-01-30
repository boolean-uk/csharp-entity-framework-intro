using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.AspNetCore.Components.Web;
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
            return await _db.Publishers.Include(b => b.Authors).Include(b => b.Books).ToListAsync();
        }

        public async Task<Publisher?> GetAPublisher(int publisherId)
        {
            return await _db.Publishers.Include(b => b.Authors).FirstOrDefaultAsync(b => b.Id == publisherId);
        }
    }
}
