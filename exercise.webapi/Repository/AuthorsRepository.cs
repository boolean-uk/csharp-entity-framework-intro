using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class AuthorsRepository : IAuthorsRepository
    {
        DataContext _db;
        public AuthorsRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Author>> GetAllAuthorsAsync()
        {
            return await _db.Authors.Include(a => a.Books).ToListAsync();
        }
        public async Task<Author?> GetAuthor(int authorId)
        {
            return await _db.Authors.Include(a => a.Books).FirstOrDefaultAsync(a => a.Id == authorId);
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
