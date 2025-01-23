using exercise.webapi.Data;
using exercise.webapi.DTO;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class PublisherRepository : IPublisherRepository
    {
        private readonly DataContext _db;

        public PublisherRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<PublisherGetDTO>> GetAllPublishers()
        {
            return await _db.Publishers
                .Include(p => p.Books)
                .ThenInclude(b => b.Author)
                .Select(p => new PublisherGetDTO
                {
                    Id = p.Id,
                    Name = p.Name,
                    Books = p.Books.Select(b => new BookGetDTO
                    {
                        Id = b.Id,
                        Title = b.Title,
                        Author = new AuthorGetDTO
                        {
                            Id = b.Author.Id,
                            FirstName = b.Author.FirstName,
                            LastName = b.Author.LastName,
                            Email = b.Author.Email
                        },
                        Publisher = null
                    }).ToList()
                })
                .ToListAsync();
        }

        public async Task<PublisherGetDTO> GetPublisherById(int id)
        {
            return await _db.Publishers
                .Include(p => p.Books)
                .ThenInclude(b => b.Author)
                .Where(p => p.Id == id)
                .Select(p => new PublisherGetDTO
                {
                    Id = p.Id,
                    Name = p.Name,
                    Books = p.Books.Select(b => new BookGetDTO
                    {
                        Id = b.Id,
                        Title = b.Title,
                        Author = new AuthorGetDTO
                        {
                            Id = b.Author.Id,
                            FirstName = b.Author.FirstName,
                            LastName = b.Author.LastName,
                            Email = b.Author.Email
                        },
                        Publisher = null // Prevents circular reference
                    }).ToList()
                })
                .FirstOrDefaultAsync();
        }
    }
}
