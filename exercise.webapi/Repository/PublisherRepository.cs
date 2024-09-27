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

        // Getting a Publisher should return all books that have that publisher + the author for each book.
        public async Task<IEnumerable<Publisher>> GetAllPublishers()
        {
            return await _db.Publishers.Include(p => p.Books).ThenInclude(b => b.Author).ToListAsync();
        }

        public async Task<Publisher?> GetPublisherById(int id){
            return await _db.Publishers.Include(p => p.Books).ThenInclude(b => b.Author).FirstOrDefaultAsync(p => p.Id == id);
        }
        
    }
}