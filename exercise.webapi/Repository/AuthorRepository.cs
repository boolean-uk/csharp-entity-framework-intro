using exercise.webapi.Data;
using exercise.webapi.Models;
using exercise.webapi.DTO;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly DataContext _db;

        public AuthorRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<AuthorGetDTO>> GetAllAuthors()
        {
            return await _db.Authors
                .Include(a => a.Books)
                .Select(a => new AuthorGetDTO
                {
                    Id = a.Id,
                    FirstName = a.FirstName,
                    LastName = a.LastName,
                    Email = a.Email
                })
                .ToListAsync();
        }

        public async Task<AuthorGetDTO> GetAuthorById(int id)
        {
            return await _db.Authors
                .Include(a => a.Books)
                .ThenInclude(b => b.Publisher)
                .Where(a => a.Id == id)
                .Select(a => new AuthorGetDTO
                {
                    Id = a.Id,
                    FirstName = a.FirstName,
                    LastName = a.LastName,
                    Email = a.Email,
                    Books = a.Books.Select(b => new BookGetDTO
                    {
                        Id = b.Id,
                        Title = b.Title,
                        Author = null,
                        Publisher = new PublisherGetDTO
                        {
                            Id = b.Publisher.Id,
                            Name = b.Publisher.Name
                        }
                    }).ToList()
                })
                .FirstOrDefaultAsync();
        }
    }
}