using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class AuthorRepository: IAuthorsRepository
    {
        DataContext _db;
        
        public AuthorRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Author>> GetAllAuthors()
        {
            return await _db.Authors.Include(b => b.Books).ThenInclude(b => b.Publisher).ToListAsync();

        }

        public async Task<Author?> GetAuthor(int authorId) 
        {
            return await _db.Authors.Include(b => b.Books).ThenInclude(b => b.Publisher).FirstOrDefaultAsync(x => x.Id == authorId);
        }

        public void SaveChanges()
        {
            _db.SaveChanges();  
        }
    }
}
