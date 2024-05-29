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

        public async Task<IEnumerable<Book>> GetBooksAsync()
        {
            return await _db.Books.Include(b => b.Author).ToListAsync();
            //return await _db.Books.ToListAsync();
        }

        public async Task<Book?> GetBook(int bookId)
        {
            // includes the book if an author is find by id
            return await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == bookId);
        }

        public async Task<Book?> UpdateBookAuthor(int bookId, int newAuthorId)
        {
            var book = await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == bookId);
            book.AuthorId = newAuthorId;
            _db.SaveChanges();
            return book;
        }

        public async Task<Book?> DeleteBookAuthor(int bookId)
        {
            var book = await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(a => a.Id == bookId);
            _db.Books.Remove(book);
            _db.SaveChanges();
            return book;
        }
        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
