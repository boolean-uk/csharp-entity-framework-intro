using exercise.webapi.Data;
using exercise.webapi.Models;
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
        public async Task<DTOAuthor> GetAuthor(int id)
        {
            var dtobook = await _db.Authors.Include(b => b.Books).SingleOrDefaultAsync(b => b.Id == id);
            var dtobook2 = new DTOAuthor()
            {
                Email = dtobook.Email,
                FirstName = dtobook.FirstName,
                LastName = dtobook.LastName,
                Id = dtobook.Id,
                books = DTOBook.getDTOBooks((List<Book>)dtobook.Books)
            };
            return dtobook2;
        }

        public async Task<List<DTOAuthor>> GetAuthors()
        {
            List<DTOAuthor> dTOAuthors = new List<DTOAuthor>();
            List<Author> authors = await _db.Authors.Include(b => b.Books).ToListAsync();
            foreach (Author author in authors)
            {
                DTOAuthor dtoAuthor = new DTOAuthor();
                dtoAuthor.Email = author.Email;
                dtoAuthor.FirstName = author.FirstName;
                dtoAuthor.LastName = author.LastName;
                dtoAuthor.Id = author.Id;
                dtoAuthor.books = DTOBook.getDTOBooks((List<Book>)author.Books);
                dTOAuthors.Add(dtoAuthor);
            }
            return dTOAuthors;
        }
    }
}
