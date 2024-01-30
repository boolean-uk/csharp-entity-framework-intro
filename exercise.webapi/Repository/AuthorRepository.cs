using exercise.webapi.Data;
using exercise.webapi.Models;
using static exercise.webapi.Repository.IAuthorRepository;
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

        
            public async Task<IEnumerable<Author>> GetAuthorsAsync()
            {
                return await _db.Authors.Include(a => a.Books).ToListAsync();
            }

            public async Task<Author?> GetAuthor(int authorId)
            {
                return await _db.Authors.Include(a => a.Books).FirstOrDefaultAsync(a => a.Id == authorId);
            }
        

        /*
        public async Task<IEnumerable<Author>> GetAuthorsAsync()
        {
            return await _db.Authors.Include(a => a.BookAuthors).ThenInclude(ba => ba.Book).ToListAsync();
        }

        public async Task<Author?> GetAuthor(int authorId)
        {
            return await _db.Authors.Include(a => a.BookAuthors).ThenInclude(ba => ba.Book).FirstOrDefaultAsync(a => a.Id == authorId);
        }
        */

        public void SaveChanges()
            {
                _db.SaveChanges();
            }
        }
}



  

