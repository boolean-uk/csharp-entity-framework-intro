using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class BookRepository : IBookRepository
    {
        DataContext _db;

        public BookRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _db.Books.Include(b => b.Author).ToListAsync();
        }

        public async Task<Book> GetBookById(int id)
        {
            var entity = await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == id);
            return entity;
        }

        public async Task<Book> UpdateById(int id, Book entity)
        {
            _db.Attach(entity).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<Book> DeleteById(int id)
        {
            var match = await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == id);

            _db.Remove(match);
            await _db.SaveChangesAsync();
            return match;
        }
    }
}
