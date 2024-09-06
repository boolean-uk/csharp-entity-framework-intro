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

        public async Task<IEnumerable<DTOAuthor>> GetAllAuthors()
        {
            var authors = from b in _db.Authors
                          select new DTOAuthor()
                          {
                              Id = b.Id,
                              FirstName = b.FirstName,
                              LastName = b.LastName,
                              Email = b.Email,
                              Books = DTOBook.bookToDTO(b.Books.ToList()),
                          };
            return authors;
        }


        public async Task<DTOAuthor> GetAuthor(int id)
        {
            var author = await _db.Authors.Include(b => b.Books).SingleOrDefaultAsync(b => b.Id == id);
            DTOAuthor dto = new DTOAuthor()
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                Email = author.Email,
                Books = DTOBook.bookToDTO(author.Books.ToList())
            };

            return dto;



        }
    }
}
