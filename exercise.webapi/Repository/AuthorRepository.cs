using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository;

public class AuthorRepository : IAuthorRepository
{
    DataContext _db;

    public AuthorRepository(DataContext db)
    {
        _db = db;
    }

    public async Task<Author?> Get(int id)
    {
        return await _db
            .Authors.Include(b => b.Books)
            .ThenInclude(b => b.Publisher)
            .FirstOrDefaultAsync(b => b.Id == id);
    }

    public async Task<IEnumerable<Author>> GetAll()
    {
        return await _db.Authors.Include(b => b.Books).ThenInclude(b => b.Publisher).ToListAsync();
    }
}
