using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Repository
{
    public class AuthorRepository : IAuthorRepository
    {
        DataContext _db;
        public AuthorRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<AuthorAndBooksDTO> GetAuthorById(int id)
        {
            var dto = await _db.Authors.Where(a => a.Id == id).Select(a => new AuthorAndBooksDTO
            {
                FirstName = a.FirstName,
                LastName = a.LastName,
                Email = a.Email,
                Books = a.Books.Select(b => new BookAndPublisherDTO {
                    Title = b.Title,
                    PublisherName = b.Publisher.FirstName + " " + b.Publisher.LastName
                }).ToList()
            }).FirstOrDefaultAsync(); 
            return dto;
        }

        public async Task<IEnumerable<AuthorAndBooksDTO>> GetAuthors()
        {
            return await _db.Authors.Select(a => new AuthorAndBooksDTO
            {
                FirstName = a.FirstName,
                LastName = a.LastName,
                Email = a.Email,
                Books = a.Books.Select(b => new BookAndPublisherDTO { 
                    Title = b.Title,
                    PublisherName = b.Publisher.FirstName + " " + b.Publisher.LastName
                }).ToList()
            }).ToListAsync();
        }
    }
}
