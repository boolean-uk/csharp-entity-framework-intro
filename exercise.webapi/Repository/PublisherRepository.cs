
using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public interface IPublisherRepository
    {
        Task<List<Publisher>> GetAllPublishers();

        Task<Publisher> GetPublisher(int id);
    }
    public class PublisherRepository : IPublisherRepository
    {
        private DataContext _db;

        public PublisherRepository(DataContext db)
        {
            _db = db;
        }
        public async Task<List<Publisher>> GetAllPublishers()
        {

            return await _db.Publishers.Include(p => p.Books).ToListAsync();
        }

        public async Task<Publisher> GetPublisher(int id)
        {

            return await _db.Publishers.Include(a => a.Books).FirstOrDefaultAsync(a => a.Id == id);
        }
    }
}
