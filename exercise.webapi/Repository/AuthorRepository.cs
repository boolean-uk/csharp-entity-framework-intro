using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class AuthorRepository : IAuthorRepository
    {
        DataContext _db;
        public AuthorRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Author>> GetAllAuthors()
        {
            return await _db.Authors.Include(b => b.Books).ThenInclude(b => b.Publisher).ToListAsync();
        }
        public async Task<Author?> GetAuthor(int id)
        {
            return await _db.Authors.Include(t => t.Books).ThenInclude(b => b.Publisher).SingleOrDefaultAsync(t => t.Id == id);
        }
    }
}
