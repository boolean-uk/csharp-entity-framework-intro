using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{

    public interface IAuthorRepository
    {
        Task<List<Author>> GetAuthors();
        Task<Author> GetAnAuthor(int id);
    }

    public class AuthorRepository : IAuthorRepository
    {

        private DataContext _db;

        public AuthorRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<Author> GetAnAuthor(int id)
        {
            return await _db.Authors.Include(b => b.Books).FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<List<Author>> GetAuthors()
        {
            return await _db.Authors.Include(b => b.Books).ToListAsync();
        }
    }
}
