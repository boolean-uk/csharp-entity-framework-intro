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
            var authors = await _db.Authors.Include(b => b.Books).ToListAsync();

            return authors;
        }

        public async Task<Author> GetAuthor(int id)
        {
            return await _db.Authors.Include(b => b.Books).Where(b => b.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Author> AddAuthorBook(int id, Book book)
        {
            var author = await _db.Authors.Include(b => b.Books).Where(b => b.Id == id).FirstOrDefaultAsync();
            author.Books.Add(book);
            await _db.SaveChangesAsync();
            return author;
        }

    }
}
