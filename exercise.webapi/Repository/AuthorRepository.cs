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

        public async Task<Author> GetAuthorById(int id)
        {
            return await _db.Authors.FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<List<Author>> GetAllAuthors()
        {
            return await _db.Authors.Include(b => b.Books).ThenInclude(p => p.Publisher).ToListAsync();

        }
    }
}