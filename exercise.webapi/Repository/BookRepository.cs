using exercise.webapi.Data;
using exercise.webapi.DTO;
using exercise.webapi.DTOS;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class BookRepository: IBookRepository
    {
        private DataContext _db;
        
        public BookRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _db.Books.Include(a => a.Author).ToListAsync();
        }

        public async Task<Book> GetBookById(int id)
        {
            var entity = await _db.Books.Include(a => a.Author).FirstOrDefaultAsync(b => b.Id == id);

            return entity;
        }

        public async Task<Book> UpdateBookById(int id, Book entity)
        {
            _db.Attach(entity).State = EntityState.Modified;
            await _db.SaveChangesAsync();

            return entity;
        }

        public async Task<Book> DeleteBookById(int id)
        {
            var entity = await _db.Books.FirstOrDefaultAsync(b => b.Id == id);

            _db.Remove(entity);

            await _db.SaveChangesAsync();

            return entity;
        }

        public async Task<Book> CreateBook(Book entity)
        {
            _db.Books.Add(entity);

            await _db.SaveChangesAsync();

            return entity;
        }
    }
}
