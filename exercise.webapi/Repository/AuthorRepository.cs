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
        public async Task<IEnumerable<AuthorDTO>> GetAll()
        {
            var authors = await _db.Authors.Include(x=>x.Books).ToListAsync();
            
            return authors.MapListToDTO();
        }

        public async Task<AuthorDTO> GetAuthor(int id)
        {
            Author author = await _db.Authors.SingleOrDefaultAsync(x => x.Id == id);
            return author.MapToDTO();
        }
    }
}
