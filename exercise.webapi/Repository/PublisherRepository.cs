
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

        public async Task<Publisher> GetAPublisher(int? id)
        {
            

                if (id == null) { throw new BadHttpRequestException("Invalid"); }
            


            var publisher = await _db.Publishers.Include(b => b.Books).ThenInclude(a => a.Author).FirstOrDefaultAsync(x => x.Id == id);

            if (publisher == null) { throw new Exception("No match id"); }
            return publisher;
        }

        public async Task<IEnumerable<Publisher>> getPublisher()
        {
            return await _db.Publishers.Include(b => b.Books).ThenInclude(a => a.Author)        // IMPORTANT, INCLUDE BOTH ARTUHER AND BOOKS
                
                .ToListAsync();

        }
    }
}
