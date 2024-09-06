
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

        public async Task<IEnumerable<Author>> GetAllAuthors()
        {
            return await _db.Authors.Include(a => a.Books).ToListAsync();
        }

        public async Task<Author> GetAuthorById(int id)
        {
            var entity = await _db.Authors.Include(a => a.Books).FirstOrDefaultAsync(b => b.Id == id);

            if (entity == null) 
            {
                throw new Exception($"Author with id {id} does not exist.");
            }

            return entity;
        }
    }
}
