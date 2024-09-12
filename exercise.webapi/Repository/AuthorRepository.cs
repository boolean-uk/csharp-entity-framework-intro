using exercise.webapi.Data;
using exercise.webapi.DTO;
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
        public async Task<IEnumerable<GetAuthorDto>> GetAllAuthors()
        {
            return await _db.Authors.Include(a => a.Books)
              .Select(a => new GetAuthorDto()
              {
                  Email = a.Email,
                  FirstName = a.FirstName,
                  LastName = a.LastName,
                  Books = a.Books.Select(b => new GetBookDto() { AuthorDto = b.Author, Id = b.Id, Title = b.Title }).ToList(),
              })
              .ToListAsync();
        }

        public async Task<GetAuthorDto> GetAuthor(int id)
        {
            Author author = await _db.Authors.Include(a => a.Books).FirstOrDefaultAsync(a => a.Id == id)
               ?? throw new ArgumentException($"No Author with this id: {id}");
            GetAuthorDto dto = new()
            {
                Email = author.Email,
                FirstName = author.FirstName,
                LastName = author.LastName,
                Books = author.Books.Select(b => new GetBookDto() { AuthorDto = b.Author, Id = b.Id, Title = b.Title }).ToList(),
            };
            return dto;
        }
    }
}
