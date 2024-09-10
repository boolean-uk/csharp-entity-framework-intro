using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;

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

            return await _db.Books.Include(b => b.Authors).ToListAsync();
        }

        public async Task<Book> GetById(int id)
        {
            return await _db.Books.Include(b => b.Authors).FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<Book> Add(Book entity)
        {
            await _db.AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<Book> DeleteById(int id)
        {
            var bookTarget = await _db.Books.FirstOrDefaultAsync(b => b.Id == id);
            _db.Books.Remove(bookTarget);

            await _db.SaveChangesAsync();
            return bookTarget;
        }
    }
}
