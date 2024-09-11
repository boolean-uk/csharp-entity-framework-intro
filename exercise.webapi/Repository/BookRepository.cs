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

        public async Task<Book> AddBook(Book entity)
        {
            await _db.Books.AddAsync(entity);
            await _db.SaveChangesAsync();   
            return entity;
        }

        public async Task<Book> DeleteBookById(int id)
        {
            Book book = GetBookById(id).Result;
            _db.Books.Remove(book);  //Async method for this?
            await _db.SaveChangesAsync();
            return book;
        }

        public async Task<List<Book>> GetAllBooks()
        {
            return await _db.Books.Include(b => b.Author).Include(b => b.Publisher).ToListAsync();

        }

        public async Task<Book> GetBookById(int id)
        {
            return await _db.Books.Include(b => b.Author).Include(b => b.Publisher).FirstOrDefaultAsync(book => book.Id == id);
        }

        public async Task<Book> UpdateBookAuthorById(Book entity, int id)
        {
            _db.Attach(entity).State = EntityState.Modified;
            await _db.SaveChangesAsync();

            return entity;
        }
    }
}
