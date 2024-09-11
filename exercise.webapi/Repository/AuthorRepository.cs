using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class AuthorRepository : IAuthorRepository
    {
        private DataContext _db;

        public AuthorRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Author>> GetAllAuthors()
        {
            return await _db.Authors.Include(a => a.Books).ThenInclude(b => b.Publisher).ToListAsync();

        }

        public async Task<Author> GetOneAuthor(int id)
        {
            return await _db.Authors.Include(a => a.Books).ThenInclude(b => b.Publisher).FirstOrDefaultAsync(a => a.Id == id);
        }
    }
}
