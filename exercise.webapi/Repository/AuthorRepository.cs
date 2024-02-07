using exercise.webapi.Data;
using exercise.webapi.Models;
using exercise.webapi.Repository.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class AuthorRepository : Repository<Author>
    {
        DataContext _db;

        public AuthorRepository(DataContext db) : base(db)
        {
            _db = db;
        }

        public override async Task<IEnumerable<Author>> Get()
        {
            return await _db.Authors.Include(a => a.Books).ToListAsync();

        }

        public override async Task<Author> GetById(object id)
        {
            IEnumerable<Author> authors = await _db.Authors.Include(a => a.Books).ToListAsync();
            return authors.FirstOrDefault(a => a.Id == (int)id);
        }
    }
}
