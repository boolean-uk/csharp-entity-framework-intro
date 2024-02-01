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
        public async Task<IEnumerable<Author>> GetAllAuthors()
        {
            var authors = _db.Authors.Include(a => a.Books);
            
            return await authors.ToListAsync();
        }

        public async Task<Author> GetAuthor(int id)
        {
            Author author = await _db.Authors.Include(a => a.Books).FirstOrDefaultAsync(a => a.Id == id);
            return author;
        }
    }
}
