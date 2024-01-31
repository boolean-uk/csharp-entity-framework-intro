using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

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
            return await _db.Authors.Include(a => a.Books).ToListAsync();

        }

        
        public async Task<Author> GetAuthorByID(int authorID)
        {
            IEnumerable<Author> allAuthors = await GetAllAuthors();

            Author? author = allAuthors.FirstOrDefault(a => a.Id == authorID);

            return author;
        }
        
    }
}
