using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class AuthorRepository: IAuthorRepository
    {
        DataContext _db;
        
        public AuthorRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Author>> GetAllAuthors()
        {
            return await _db.Authors
                .Include(author => author.AuthorBooks)
                .ThenInclude(authorBook => authorBook.Book)
                .ToListAsync();
        }

        public async Task<Author?> GetAnAuthor(int authorId)
        {
            return await _db.Authors
                .Include(author => author.AuthorBooks)
                .ThenInclude(authorBook => authorBook.Book)
                .FirstOrDefaultAsync(author => author.Id == authorId);
        }

    }
}