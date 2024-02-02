using exercise.webapi.Data;
using exercise.webapi.Models.Types;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository;

public class AuthorRepository : IAuthorRepository
{
    DatabaseContext _db;

    public AuthorRepository(DatabaseContext db)
    {
        _db = db;
    }

    public async Task<IEnumerable<Author>> GetAllAuthors()
    {
        return await _db.Authors.Include(a => a.AuthorBooks).ThenInclude(ab => ab.Book).ThenInclude(b => b.Publisher).ToListAsync();
    }

    public async Task<Author?> GetAuthorById(int id)
    {
        var author = await _db.Authors.Include(a => a.AuthorBooks).ThenInclude(ab => ab.Book).ThenInclude(b => b.Publisher).FirstOrDefaultAsync(x => x.Id == id);
        if (author == null) return null;
        return author;
    }
}
