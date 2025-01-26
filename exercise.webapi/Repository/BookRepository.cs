using System.Net;
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
        public async Task<Book> Get(int id)
        {
            return await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<bool> Delete(int id)
        {
            var result = await _db.Books.FindAsync(id);
            if (result == null)
            {
                return false;
            }
            _db.Books.Remove(result);
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<Book> Add(Book book)
        {
            await _db.Books.AddAsync(book);
            await _db.SaveChangesAsync();
            return book;
        }

        public async Task<Book> Update(int authorid, int bookid)
        {
            var author = await _db.Authors.FindAsync(authorid);
            if (author == null)
            {
                return null;
            }
            var book = await _db.Books.FindAsync(bookid);
            if (book == null)
            {
                return null;
            }
            book.AuthorId = authorid;
            await _db.SaveChangesAsync();
            return book;
        }
    }
}
