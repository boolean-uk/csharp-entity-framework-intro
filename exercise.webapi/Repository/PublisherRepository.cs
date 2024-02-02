using exercise.webapi.Data;
using exercise.webapi.Models.Types;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository;

public class PublisherRepository : IPublisherRepository
{
    DatabaseContext _db;

    public PublisherRepository(DatabaseContext db)
    {
        _db = db;
    }

    public async Task<IEnumerable<Publisher>> GetAllPublishers()
    {
        return await _db.Publishers.Include(p => p.Books).ThenInclude(b => b.AuthorBooks).ThenInclude(ab => ab.Author).ToListAsync();
    }

    public async Task<Publisher?> GetPublisherById(int id)
    {
        var publisher = await _db.Publishers.Include(p => p.Books).ThenInclude(b => b.AuthorBooks).ThenInclude(ab => ab.Author).FirstOrDefaultAsync(p => p.Id == id);
        if (publisher == null)
        {
            return null;
        }
        return publisher;
    }
}
