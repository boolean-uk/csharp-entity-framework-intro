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
            var books = await _db.Authors.Include(author => author.Books).ThenInclude(book => book.Publisher).ToListAsync();
            return books;
        }

        public async Task<Author> GetAuthor(int id)
        {
            return await _db.Authors.Include(author => author.Books).ThenInclude(book => book.Publisher).FirstOrDefaultAsync(author => author.Id == id);
        }
    }
}
