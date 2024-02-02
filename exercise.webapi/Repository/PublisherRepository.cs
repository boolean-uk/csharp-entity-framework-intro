using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace exercise.webapi.Repository
{
    public class PublisherRepository : IPublisherRepository
    {
        DataContext _db;
        public PublisherRepository(DataContext db)
        {
            _db = db;
        }

        public Task<Publisher> GetPublisherById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Publisher>> GetPublishers()
        {
            return await _db.Publishers.Include(b => b.Books).ToListAsync();
        }

     
    }
}
