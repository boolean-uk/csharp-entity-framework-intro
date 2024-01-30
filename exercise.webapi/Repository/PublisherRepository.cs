using exercise.webapi.Data;
using exercise.webapi.Models;
using exercise.webapi.Models.DTOs;
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
        
        public async Task<Publisher> CreatePublisher(PublisherCreatePayload payload)
        {
            var publisher = new Publisher() {Company = payload.Company};
            await _db.Publishers.AddAsync(publisher);
            await _db.SaveChangesAsync();
            return publisher;
        }

        public async Task<ICollection<Publisher>> GetAllPublishers()
        {
            return await _db.Publishers.ToListAsync();
        }

        public async Task<Publisher> GetPublisherById(int Id)
        {
            var publisher = await _db.Publishers.FirstOrDefaultAsync(a => a.Id == Id);
            return publisher;
        }
    }
}
