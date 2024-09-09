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

        public async Task<IEnumerable<Publisher>> GetAllPublishers()
        {
            return await _db.Publishers
                .Include(a => a.Books)
                .ThenInclude(b => b.Author)
                .ToListAsync();
        }

        public async Task<Publisher> GetPublisherById(int id)
        {
            var entity = await _db.Publishers
                .Include(a => a.Books)
                .ThenInclude(b => b.Author)
                .FirstOrDefaultAsync(b => b.Id == id);

            if (entity == null)
            {
                throw new Exception($"Publisher with id {id} does not exist.");
            }

            return entity;
        }
    }
}
