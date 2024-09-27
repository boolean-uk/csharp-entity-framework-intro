using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc.TagHelpers;
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

        public async Task<Author> GetAuthorById(int id)
        {
            return await _db.Authors.Include(b => b.Books).ThenInclude(p => p.Publisher).SingleOrDefaultAsync(a => a.Id == id)
                 ?? throw new ArgumentException($"No Author with id: {id}");
        }

        public async Task<IEnumerable<Author>> GetAuthors()
        {
            return await _db.Authors.Include(b => b.Books).ThenInclude(p => p.Publisher).ToListAsync();




        }
    }
}