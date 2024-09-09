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
        public async Task<IEnumerable<PublisherDTO>> GetAll()
        {
            var publishers = await _db.Publishers.ToListAsync();
            return publishers.MapListToDTO(); // add dto
        }

        public PublisherDTO GetPublisher(int id)
        {
            return _db.Publishers.FirstOrDefault(p => p.Id == id).MapToDTO(); // add dto
        }
    }
}
