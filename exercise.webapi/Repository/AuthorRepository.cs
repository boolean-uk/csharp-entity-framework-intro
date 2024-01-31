using exercise.webapi.Data;
using exercise.webapi.DTOs;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly DataContext _context;

        public AuthorRepository(DataContext context) 
        {
            _context = context;
        }

        public async Task<ICollection<GetAuthorDTO>> GetAll()
        {
            return await _context.Authors
                .Include(a => a.Books)
                .Select(a => new GetAuthorDTO()
                {
                    Email = a.Email,
                    FirstName = a.FirstName,
                    LastName = a.LastName,
                    Books = a.Books.Select(b => new GetBookDTO() { Author=b.Author, Id=b.Id, Title=b.Title }).ToList(),
                })
                .ToListAsync();
        }

        public async Task<GetAuthorDTO> GetById(int id)
        {
            Author author = await _context.Authors
                .Include(a => a.Books)
                .FirstOrDefaultAsync(a => a.Id == id)
                ?? throw new ArgumentException($"No author with id: {id}");
            GetAuthorDTO dto = new()
            {
                Email = author.Email,
                FirstName = author.FirstName,
                LastName = author.LastName,
                Books = author.Books.Select(b => new GetBookDTO() { Author=b.Author, Id=b.Id, Title=b.Title}).ToList(),
            };
            return dto;
        }
    }
}
