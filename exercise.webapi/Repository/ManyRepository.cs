using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class ManyRepository: IManyRepository
    {
        DataContext _db;
        
        public ManyRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<BookAuthor>> GetAllRelationships()
        {
            return await _db.BookAuthors.ToListAsync();

        }

        public async Task<BookAuthor?> GetRelationship(int authorId, int bookId) 
        {
            return await _db.BookAuthors.Where(x => x.BookId == bookId).FirstOrDefaultAsync(x => x.AuthorId == authorId);
        }


        public async Task<BookAuthor> AddRelationship(BookAuthor ba)
        {
            _db.BookAuthors.Add(ba);

            return ba;
        }

        public void SaveChanges()
        {
            _db.SaveChanges();  
        }
    }
}
