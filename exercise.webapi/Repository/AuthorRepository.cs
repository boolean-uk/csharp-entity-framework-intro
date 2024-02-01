using exercise.webapi.Data;
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

        public async Task<Author> GetAnAuthors(int? id)
        {
            if (id == null) { throw new BadHttpRequestException("Invalid"); }
            Author author = await _db.Authors.Include(a => a.Books).ThenInclude(p => p.Publisher).FirstOrDefaultAsync(a => a.Id == id);

            if (author == null) { throw new Exception("No match id"); }
            return author;
        }

        public async Task<IEnumerable<Author>> GetAuthors()
        {

             return await _db.Authors.Include(a => a.Books).ThenInclude(p => p.Publisher).ToListAsync();     // Not working
           // return await _db.Authors.AsNoTracking().Include(a => a.Books).ToListAsync(); //Not working

            //return await _db.Authors.Include(a => a.Books).Select(a => new Author() { })

        }

        





        private async Task<IEnumerable<Book>> GetBooks(int authorId)
        {
            //List<Book> bookList = new List<Book>();
            List<Book> bookList = await _db.Books.Where(b => b.AuthorId == authorId).ToListAsync();
            return bookList;
        }

    }
}
