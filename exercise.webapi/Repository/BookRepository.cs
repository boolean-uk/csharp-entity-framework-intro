using exercise.webapi.Data;
using exercise.webapi.DTO;
using exercise.webapi.Exceptions;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class BookRepository : IRepository<Book>
    {
        DataContext _db;
        
        public BookRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<Book> Add(Book entity)
        {
            await _db.Books.AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<Book> Delete(int id)
        {
            Book book = await Get(id);
            _db.Books.Remove(book);
            await _db.SaveChangesAsync();
            return book;
        }

        public async Task<Book> Get(int id)
        {
            Book? book = await _db.Books.Include(b => b.Author).SingleOrDefaultAsync(x => x.Id == id);
            if (book == null) throw new IdNotFoundException("The provided book Id does not exist!");
            return book;
        }

        public async Task<IEnumerable<Book>> GetAll()
        {
            return await _db.Books.Include(book => book.Author).ToListAsync();
        }

        public async Task<Book> Update(Book entity)
        {
            if (_db.Entry(entity).State == EntityState.Detached)
            {
                _db.Books.Attach(entity);
                _db.Entry(entity).State = EntityState.Modified;
            }

            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
