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
        public async Task<Author> GetAuthor(int id)
        {
            return await
                _db.Authors.
                Include(a => a.Books).ThenInclude(ba => ba.Book).ThenInclude(b => b.Publisher).
                FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<List<Author>> GetAuthors()
        {
            return await
                _db.Authors.
                Include(a => a.Books).ThenInclude(ba => ba.Book).ThenInclude(b => b.Publisher).
                ToListAsync();
        }
    }
}
