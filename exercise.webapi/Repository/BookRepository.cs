using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class BookRepository: IBookRepository
    {
        DataContext _db;
        
        public BookRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Book>> GetAll()
        {
            return await _db.Books.Include(b => b.Authors).Include(p => p.Publisher).ToListAsync();

        }
        public async Task<Book> GetA(int id) 
        { 
            return await _db.Books.Include(b => b.Authors).Include(p => p.Publisher).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Book> Update(Book book)
        {
            _db.Books.Update(book);
            await _db.SaveChangesAsync();
            return book;
        }

        public async Task<Book> Delete(int id)
        {
            var book = await GetA(id);
            if (book == null) return book;
            _db.Books.Remove(book);
            await _db.SaveChangesAsync();
            return book;
        }
    }
}
