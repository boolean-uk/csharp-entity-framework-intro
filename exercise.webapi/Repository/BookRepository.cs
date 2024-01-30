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
            return await _db.Books.Include(b => b.BookAuthors).ThenInclude(b => b.Author).Include(p => p.Publisher).ToListAsync();

        }

        public async Task<Book?> GetBook(int bookId) 
        {
            // return await _db.Posts.Include(p => p.Author).FirstOrDefaultAsync(p => p.Id == postId);
            return await _db.Books.Include(b => b.BookAuthors).ThenInclude(a => a.Author).Include(p => p.Publisher).FirstOrDefaultAsync(x => x.Id == bookId);
        }

        public async Task<Book> AddBook(Book book)
        {
            // return await _db.Posts.Include(p => p.Author).FirstOrDefaultAsync(p => p.Id == postId);

            _db.Books.Add(book);

            return book;
        }

        public async Task<Book?> DeleteBook(int bookId)
        {
            // return await _db.Posts.Include(p => p.Author).FirstOrDefaultAsync(p => p.Id == postId);

            var b = await _db.Books.Include(a => a.BookAuthors).ThenInclude(a => a.Author).FirstOrDefaultAsync(x => x.Id == bookId);

            if (b != null)
            {
                _db.Books.Remove(b);
            }

            return b;
        }

        public void SaveChanges()
        {
            _db.SaveChanges();  
        }
    }
}
