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

        public async Task<Author> GetAuthorByName(string FirstName, string LastName)
        {
            return await _db.Authors.FirstOrDefaultAsync(x => x.FirstName == FirstName && x.LastName == LastName);
        }
    }
}
