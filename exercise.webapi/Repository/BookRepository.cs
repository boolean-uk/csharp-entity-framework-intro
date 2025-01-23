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

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _db.Books.Include(b => b.Author).ToListAsync();

        }

        public async Task<Book> GetBook(int id)
        {
            return await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<Book> UpdateBook(Book entity)
        {
            _db.Books.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return entity;
        }
        public async Task<Book> DeleteBook(int id)
        {
            var target = await _db.Books.FirstOrDefaultAsync(b => b.Id == id);
            _db.Books.Remove(target);
            _db.SaveChanges();
            return target;
        }
        public async Task<Book> CreateBook(Book entity)
        {
            await _db.Books.AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
