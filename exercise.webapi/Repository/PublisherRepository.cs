using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

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
            return await _db.Publishers.Include(p => p.Books)
                .ThenInclude(b => b.Author).ToListAsync();
        }

        
        public async Task<Publisher> GetPublisherByID(int id)
        {
            IEnumerable<Publisher> allPublishers = await GetAllPublishers();

            Publisher? publisher = allPublishers.FirstOrDefault(p => p.Id == id);

            return publisher;
        }
        
    }
}
