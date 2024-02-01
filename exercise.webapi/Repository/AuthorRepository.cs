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
        public async Task<IEnumerable<AuthorDTO>> GetAllAuthors()
        {
            var authors = from author in _db.Authors
                        select new AuthorDTO()
                        {
                            Id = author.Id,
                            FirstName = author.FirstName,
                            LastName = author.LastName,
                            Email = author.Email,
                        };
            return await authors.ToListAsync();
        }

        public Task<AuthorDTO> GetAuthor(int id)
        {
            throw new NotImplementedException();
        }
    }
}
