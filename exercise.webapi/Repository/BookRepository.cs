using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.Extensions.Hosting;

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

       
        public async Task<Book?> GetBook(int bookId)
        {
            return await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == bookId);
        }
        

        /*
        public async Task<IEnumerable<Book>> GetAllBooks(bool includeAuthors = false)
        {
            var query = _db.Books.Include(b => b.BookAuthors);

            if (includeAuthors)
            {
                query = query.Include(b => b.BookAuthors).ThenInclude(ba => ba.Author);
            }

            return await query.ToListAsync();
        }


        public async Task<Book?> GetBook(int bookId, bool includeAuthors = false)
        {
            var query = _db.Books.Include(b => b.BookAuthors);

            if (includeAuthors)
            {
                query = query.Include(b => b.BookAuthors).ThenInclude(ba => ba.Author);
            }

            return await query.FirstOrDefaultAsync(b => b.Id == bookId);
        }
        */

        public async Task<Book?> DeleteBook(int bookId)
        {
            var book = await GetBook(bookId);
            if (book == null)
            {
                return null;
            }
            _db.Books.Remove(book);
            //await _db.SaveChangesAsync();

            return book;
        }

        public async Task AddBook(Book book)
        {
            _db.Books.Add(book);
            await _db.SaveChangesAsync();
            //return book;
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
