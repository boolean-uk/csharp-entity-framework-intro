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

        public async Task<Author> GetA(int id)
        {
            return await _db.Authors.Include(a => a.Books).ThenInclude(p => p.Publisher).FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<IEnumerable<Author>> GetAll()
        {
            return await _db.Authors.Include(a => a.Books).ThenInclude(p => p.Publisher).ToListAsync();
        }

        public async Task<Author> Update(Author author)
        {
            _db.Authors.Update(author);
            await _db.SaveChangesAsync();
            return author;
        }
    }
}
