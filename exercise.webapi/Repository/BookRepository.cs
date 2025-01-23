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

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            var books = await _db.Books
                .Include(b => b.BookAuthors)
                .ThenInclude(ba => ba.Author)
                .Include(b => b.Publisher)
                .ToListAsync();
            books.ForEach(b => b.Authors = b.BookAuthors.Select(ba => ba.Author).ToList());
            return books;
        }

        public async Task<Book> GetBook(int id)
        {
            var book = await _db.Books
                .Include(b => b.BookAuthors)
                .ThenInclude(ba => ba.Author)
                .Include(b => b.Publisher)
                .FirstOrDefaultAsync(b => b.Id == id);
           book.Authors = book.BookAuthors.Select(ba => ba.Author).ToList();
            return book;
        }
   
        public async Task<Book> UpdateBook(Book book)
        {
            _db.Books.Update(book);
            await _db.SaveChangesAsync();
            return book;
        }

        public async Task<bool> DeleteBook(int id)
        {
            var book = await _db.Books.FindAsync(id);
            if (book == null)
            {
                return false;
            }
            _db.Books.Remove(book);
            await _db.SaveChangesAsync();
            return true;
        }
        public async Task<Book> AddBook(Book book)
        {
            await _db.Books.AddAsync(book);
            await _db.SaveChangesAsync();
            return book;
        }
    }
}
