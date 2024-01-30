using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;
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
            return await _db.Books.Include(p => p.Author).FirstOrDefaultAsync(p => p.Id == bookId);
        }

        public async Task<Book?> DeleteBook(int bookId)
        {
            Book? book = await _db.Books.Include(p => p.Author).FirstOrDefaultAsync(p => p.Id == bookId);
            if (book == null)
            {
                return book;
            }
            _db.Books.Remove(book);
            _db.SaveChanges();
            return book;
        }

        public async Task<Book?> CreateBook(int bookId, int authorId, Author author, string title)
        {
            var existingBook = await _db.Books.FirstOrDefaultAsync(b => b.Id == bookId);
            if (existingBook != null)
            {
                return null;
            }
            Book book = new Book { Title = title, Author = author, AuthorId = authorId, Id = bookId };
            _db.Books.Add(book);
            _db.SaveChanges();
            return book;

        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
