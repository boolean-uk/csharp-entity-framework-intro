using exercise.webapi.Data;
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
            return await _db.Books.Include(b => b.Author).ToListAsync();

        }

        public async Task<Book> GetABook(int id)
        {
            return await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<Book> AddBook(Book book)
        {
            await _db.AddAsync(book);
            await _db.SaveChangesAsync();
            return book;
        }

        public async Task<Book> UpdateBook(Book toUpdate)
        {
            _db.Attach(toUpdate).State = EntityState.Modified;
            await _db.SaveChangesAsync();

            return toUpdate;
            

        }

        public async Task<Book> DeleteBook(int id)
        {
            var book = await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == id);

            if (book != null)
            {
                _db.Books.Remove(book);
                await _db.SaveChangesAsync();
            }

            return book;
        }
    }
}
