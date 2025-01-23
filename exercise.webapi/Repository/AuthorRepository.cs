using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class AuthorRepository : IRepository<Author>
    {
        DataContext _db;

        public AuthorRepository(DataContext db) 
        {
            _db = db;
        }
        public async void SaveRepository()
        {
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Author>> GetAllEntities()
        {
            return await _db.Authors.Include(a => a.Books).ToListAsync();
        }

        public async Task<Author> GetEntityById(int id)
        {
            return await _db.Authors.Include(a => a.Books).FirstOrDefaultAsync(a => a.Id == id);
        }

        public Task<bool> DeleteEntity(Author author)
        {
            throw new NotImplementedException();
        }

    }
}
