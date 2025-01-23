using exercise.webapi.Data;
using exercise.webapi.DTOs;
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

        public async Task<IEnumerable<AuthorDTO>> GetAllAuthors()
        {
            var authors = await _db.Authors.Include(a => a.Books).ToListAsync();

            if (authors == null || !authors.Any())
                throw new KeyNotFoundException("No authors found.");

            return authors.Select(author => new AuthorDTO(author));
        }

        public async Task<AuthorDTO> GetAuthorById(int id)
        {
            var author = await _db.Authors.Include(a => a.Books).FirstOrDefaultAsync(a => a.Id == id);

            if (author == null)
                throw new KeyNotFoundException("Author not found.");

            return new AuthorDTO(author);
        }
    }
}
