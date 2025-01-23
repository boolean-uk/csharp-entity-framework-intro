namespace exercise.webapi.Repository;

using System.Collections.Generic;
using System.Threading.Tasks;
using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

public class PublisherRepository : IPublisherRepository
{
    DataContext _db;

    public PublisherRepository(DataContext db)
    {
        _db = db;
    }

    public async Task<Publisher?> Get(int id)
    {
        return await _db
            .Publisher.Include(p => p.Books)
            .ThenInclude(b => b.Author)
            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task<IEnumerable<Publisher>> GetAll()
    {
        return await _db.Publisher.Include(p => p.Books).ThenInclude(b => b.Author).ToListAsync();
    }
}
