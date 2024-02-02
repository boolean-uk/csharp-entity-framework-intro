using exercise.webapi.AlternativeModels;
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

        public async Task<Book> CreateBook(Book book)
        {
            _db.Books.Add(book);
            _db.SaveChanges();

            int id = _db.Books.Max(x => x.Id);
            var newBook = await 
                _db.Books.Include(b => b.Authors).Include(b => b.Publisher).
                FirstOrDefaultAsync(x => x.Id == id);

            return newBook;
        }

        public async Task<Book> DeleteBook(int id)
        {
            var book = await 
                _db.Books.Include(b => b.Authors).Include(b => b.Publisher).
                FirstOrDefaultAsync(x => x.Id == id);
            _db.Books.Remove(book);
            _db.SaveChanges();

            return book;
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await 
                _db.Books.Include(b => b.Authors).
                ThenInclude(ba => ba.Author).Include(b => b.Publisher).
                ToListAsync();

        }

        public async Task<Book> GetBook(int id)
        {
            return await 
                _db.Books.Include(b => b.Authors).ThenInclude(ba => ba.Author).Include(b => b.Publisher).
                FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Book> UpdateBook(Book book)
        {
            _db.Books.Attach(book);
            _db.Entry(book).State = EntityState.Modified;
            await _db.SaveChangesAsync();

            return await 
                _db.Books.Include(b => b.Publisher).Include(b => b.Authors).ThenInclude(ba => ba.Author).
                FirstOrDefaultAsync(x => x.Id == book.Id);
        }
    }
}
 