using exercise.webapi.Data;
using exercise.webapi.DTO;
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
            var authors = from b in _db.Authors
                          select new AuthorDTO()
                          {
                              Id = b.Id,
                              FirstName = b.FirstName,
                              LastName = b.LastName,
                              Email = b.Email,
                              Books = BookDTO.bookToDTO(b.Books.ToList()),
                          };
            return authors;
        }

        public async Task<AuthorDTO> GetAuthor(int id)
        {
            var author = await _db.Authors.Include(b => b.Books).SingleOrDefaultAsync(b => b.Id == id);
            AuthorDTO dto = new AuthorDTO(){
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                Email = author.Email,
                Books = BookDTO.bookToDTO(author.Books.ToList())
            };

            return dto;
        }
    }
}
