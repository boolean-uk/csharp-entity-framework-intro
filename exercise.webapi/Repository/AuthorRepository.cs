using exercise.webapi.Data;
using exercise.webapi.Models.DTO;
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
        public async Task<IEnumerable<GetAuthorDTO>> GetAllAuthors()
        {
            return await _db.Authors.Select(x => new GetAuthorDTO()
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Email = x.Email,
                BookTitle = x.Books.Select(x => x.Title).ToArray(),
            }).ToListAsync();
        }

        public async Task<GetAuthorDTO?> GetAuthorById(int id)
        {
            return await _db.Authors.Where(x => x.Id == id).Select(x => new GetAuthorDTO()
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Email = x.Email,
                BookTitle = x.Books.Select(x => x.Title).ToArray(),
            }).FirstOrDefaultAsync();
        }
    }
}
