using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class PublisherRepository: IPublisherRepository
    {
        DataContext _db;
        
        public PublisherRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Publisher>> GetAllPublishers()
        {
       
            return await _db.Publishers.Include(p => p.Books).ThenInclude(b => b.Author).ToListAsync();

        }

        public async Task<Publisher?> GetPublisher(int publId)
        {
            return await _db.Publishers.Include(b => b.Books).ThenInclude(b => b.Author).FirstOrDefaultAsync(x => x.Id == publId);
        }

        public void SaveChanges()
        {
            _db.SaveChanges();  
        }
    }
}
