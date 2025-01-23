using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class AuthorRepository: IAuthorRepository
    {
        DataContext _db;
        public AuthorRepository(DataContext db)
        {
            _db = db;
        }


        public async Task<Author> GetAuthor(int id)
        {
            var author =  await _db.Authors
                .Include(a => a.BookAuthors)
                .ThenInclude(ba => ba.Book)
                .ThenInclude(b => b.Publisher)
                .FirstOrDefaultAsync(a => a.Id == id);
            author.Books = author.BookAuthors.Select(ba => ba.Book).ToList();
            return author;
        }



        public async Task<IEnumerable<Author>> GetAuthors()
        {
            var authors =  await _db.Authors
                .Include(a => a.BookAuthors)
                .ThenInclude(ba => ba.Book)
                .ThenInclude(b => b.Publisher)
                .ToListAsync();
            authors.ForEach(a => a.Books = a.BookAuthors.Select(ba => ba.Book).ToList());
            return authors;
        }
    }
}
