using exercise.webapi.Data;
using exercise.webapi.DTO;
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

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _db.Books.Include(b => b.Author).ToListAsync();

        }

        public async Task<Book> Get(int id)
        {
            return await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Book> Create(Book book)
        {
            _db.Books.Add(book);
            await _db.SaveChangesAsync();
            return book;
        }

        public async Task<bool> Update(Book book)
        {
            _db.Update(book);
            _db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Delete(Book book)
        {
            _db.Books.Remove(book);
            _db.SaveChangesAsync();
            return true;
        }
    }
}
