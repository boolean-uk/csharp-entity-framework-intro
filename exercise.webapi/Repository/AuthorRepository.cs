using exercise.webapi.Data;
using exercise.webapi.DTO_s;
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
            return await _db.Authors
                .Include(b => b.Books)
                .ThenInclude(a => a.Publisher)
                .ToListAsync();
        }

        public async Task<Author> GetAuthor(int id)
        {
            return await _db.Authors.Include(b => b.Books).ThenInclude(a => a.Publisher).FirstAsync(b => b.Id == id);
        }
    }
}
