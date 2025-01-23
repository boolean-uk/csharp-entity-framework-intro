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
            return await _db.Authors.Include(b => b.Books).ThenInclude(b => b.Publisher).ToListAsync();
        }

        public async Task<Author> GetAuthor(int id)
        {
            return await _db.Authors.Include(b => b.Books).ThenInclude(b => b.Publisher).Where(b => b.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Author> AddAuthorBook(int id, Book book)
        {
            var author = await _db.Authors.Include(b => b.Books).ThenInclude(b => b.Publisher).Where(b => b.Id == id).FirstOrDefaultAsync();
            author.Books.Add(book);
            await _db.SaveChangesAsync();
            return author;
        }

    }
}
