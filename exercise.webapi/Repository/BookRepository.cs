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

        public async Task<Book?> GetBookById(int id)
        {
            return await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<Book> AddBook(string title, int authorId)
        {
            var author = await _db.Authors.FirstOrDefaultAsync(a => a.Id == authorId);
            if (author == null)
            {
                throw new ArgumentException("Author not found");
            }
            var book = new Book {Title = title, Author = author};
            _db.Books.Add(book);
            await _db.SaveChangesAsync();
            return book;
        }

        public async Task<Book?> UpdateBook(int id, int authorId)
        {
            var book = await _db.Books.FirstOrDefaultAsync(b => b.Id == id);
            if (book == null)
            {
                return null;
            }
            var author = await _db.Authors.FirstOrDefaultAsync(a => a.Id == authorId);
            if (author == null)
            {
                throw new ArgumentException("Author not found");
            }
            book.Author = author;
            await _db.SaveChangesAsync();
            return book;
        }

        public async Task<Book?> DeleteBook(int id)
        {
            var book = await _db.Books.FirstOrDefaultAsync(b => b.Id == id);
            if (book == null)
            {
                return null;
            }
            _db.Books.Remove(book);
            await _db.SaveChangesAsync();
            return book;
        }
    }
}
