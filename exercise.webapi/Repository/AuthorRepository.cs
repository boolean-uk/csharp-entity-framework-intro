using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class AuthorRepository
    {

        DataContext _db;

        public AuthorRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<Author> GetAuthor(int id)
        {
            return _db.Authors.FirstOrDefault(x => x.Id == id);
        }

        public async Task<IEnumerable<Author>> GetAllAuthors()
        {
            return await _db.Authors.ToListAsync();

        }

    }
}
