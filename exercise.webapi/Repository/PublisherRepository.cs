using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class PublisherRepository : IPublisherRepository
    {
        private DataContext _db;

        public PublisherRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Publisher>> GetAll()
        {
            return await _db.Publishers.Include(b => b.Books).ThenInclude(b => b.Author).ToListAsync();
        }

        public async Task<Publisher> GetA(int id)
        {
            return await _db.Publishers.Include(b => b.Books).ThenInclude(b => b.Author).FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
