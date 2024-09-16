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

        public async Task<IEnumerable<Author>> GetAuthors()
        {
            return await _db.Authors.Include(author => author.Books).ToListAsync();
        }

        public async Task<Author> GetAuthor(int id)
        {
            return await _db.Authors.Include(author => author.Books).FirstOrDefaultAsync(author => author.Id == id);
        }

    }
}
