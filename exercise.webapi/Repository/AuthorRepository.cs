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
            return await _db.Authors.Include(b => b.Books).ToListAsync();
        }

        public async Task<Author> GetAnAuthor(string firstname, string lastname)
        {
            return _db.Authors.Include(b => b.Books).FirstOrDefault(a => a.FirstName.Equals(firstname) && a.LastName.Equals(lastname));
        }
    }
}
