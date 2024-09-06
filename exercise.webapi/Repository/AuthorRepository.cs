using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{

    public class AuthorRepository : IRepository<Author, AuthorDTO>
    {
        DataContext _db;
        public AuthorRepository(DataContext db) 
        {
            _db = db;
        }
        public async Task<IEnumerable<Author>> GetAll()
        {
            return await _db.Authors.Include(a => a.Books).ToListAsync();
        }

        public async Task<Author> Get(int id)
        {
            return await _db.Authors.Include(a => a.Books).FirstOrDefaultAsync(a => a.Id == id);
        }

        public Task<Author> Add(AuthorDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<Author> Update(int id, AuthorDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<Author> Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
