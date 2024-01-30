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

        public async Task<Book?> GetBookById(int id)
        {
            return await _db.Books.Include(p => p.Author).FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Book?> DeleteBookById(int id)
        {
            var result = await GetBookById(id);
            if (result == null)
            {
                return null;
            }
            _db.Remove(result);
            await _db.SaveChangesAsync();
            return result;
        }

        public void SaveChanges()
        {
            _db.SaveChanges();   
        }
    }
}
