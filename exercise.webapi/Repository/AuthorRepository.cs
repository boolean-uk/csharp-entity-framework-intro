using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class AuthorRepository : IAuthorRepository
    {

        private DataContext _db;
        public AuthorRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<List<Author>> GetAllAuthors()
        {
            return await _db.Authors.Include(a => a.Books).ToListAsync();

        }

        public async Task<Author> GetAuthor(int id)
        {
            Author author = await _db.Authors.Include(a => a.Books).FirstOrDefaultAsync(a => a.Id == id);
            return author;
        }

        


    }
}
