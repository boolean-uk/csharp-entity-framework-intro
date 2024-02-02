using exercise.webapi.Data;
using exercise.webapi.DTO;
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
                .Include(a=>a.Books)
                .ThenInclude(b=>b.Publisher)
                .OrderBy(a => a.Id)
                .ToListAsync();
        }

        public async Task<Author> GetAuthorById(int id)
        {
            var author = await _db.Authors
                .Include(a => a.Books)
                .ThenInclude(b => b.Publisher)
                .FirstAsync(a => a.Id == id);
            return author;
        }
    }
}
