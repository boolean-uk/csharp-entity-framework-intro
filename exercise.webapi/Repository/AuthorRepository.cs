using exercise.webapi.Data;
using exercise.webapi.Models;
using exercise.webapi.Models.DatabaseModels;
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
            return await _db.Authors.Include(b => b.Books).ThenInclude(b=>b.Publisher).ToListAsync();
        }

        public async Task<Author> GetAAuthor(int id)
        {
            return await _db.Authors.Include(b => b.Books).ThenInclude(b => b.Publisher).FirstAsync(b => b.Id == id);
        }
    }
}
