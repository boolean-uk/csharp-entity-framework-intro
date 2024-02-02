using exercise.webapi.Data;
using exercise.webapi.Models.BaseModels;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace exercise.webapi.Repository
{
    public class AuthorRepository: IRepository<Author>
    {
        DataContext _db;

        public AuthorRepository(DataContext db)
        {
            _db = db;
        }

        public Task<Author> Delete(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<Author> Get(object id)
        {
            return await _db.Authors.Include(a => a.Books).FirstOrDefaultAsync(a => a.ID == (int)id);
        }

        public async Task<IEnumerable<Author>> GetAll()
        {
            return await _db.Authors.Include(a => a.Books).ToListAsync();
        }

        public async Task<Author> Insert(Author entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Author> Update(Author entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> IsAnExistingID(object id)
        {
            var author = await _db.Authors.FindAsync(id);
            return author != null;
        }
    }
}
