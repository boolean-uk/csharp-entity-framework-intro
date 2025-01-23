using exercise.webapi.Data;
using exercise.webapi.Models;
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
            var publishers = await _db.Publishers.Include(b => b.Books).ThenInclude(a => a.Author).ToListAsync();

            return publishers;
        }

        public async Task<Publisher> GetPublisher(int id)
        {
            return await _db.Publishers.Include(b => b.Books).ThenInclude(a => a.Author).Where(b => b.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Publisher> AddPublisherBook(int id, Book book)
        {
            var publisher = await _db.Publishers.Include(b => b.Books).Where(b => b.Id == id).FirstOrDefaultAsync();
            publisher.Books.Add(book);
            await _db.SaveChangesAsync();
            return publisher;
        }
    }
}
