using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository.AuthorRepo
{
    public class AuthorRepository : IAuthorRepository
    {
        DataContext _db;

        public AuthorRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<Author?> GetByIdAsync(int id)
        {
            return await _db.Authors.Include(a => a.Books).ThenInclude(a => a.Publisher).FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<IEnumerable<Author>> GetAllAsync()
        {
            return await _db.Authors.Include(a => a.Books).ThenInclude(a => a.Publisher).ToListAsync();

        }
    }
}
