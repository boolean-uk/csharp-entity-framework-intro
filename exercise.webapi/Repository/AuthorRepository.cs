using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

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
            return await _db.Authors.Include(a => a.Books).ToListAsync();

        }

        public async Task<Author> GetAuthor(int id)
        {
            return await _db.Authors.Include(b => b.Books).FirstAsync(b => b.Id == id);
        }
    }
}
