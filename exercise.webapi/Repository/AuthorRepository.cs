using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{

    public interface IAuthorRepository
    {
        Task<Author> GetAnAuthor(int id);
        Task<List<Author>> GetAuthors();
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
            return await _db.Authors
                .Include(a => a.Books)
                .ThenInclude(c => c.Publisher)
                .FirstOrDefaultAsync(a => a.Id == id);
                        }

        public async Task<List<Author>> GetAuthors()
        {
            return await _db.Authors.Include(a => a.Books).ThenInclude(c => c.Publisher).ToListAsync(); ;
        }
    }
}
