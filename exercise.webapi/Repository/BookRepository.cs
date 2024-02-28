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

        public async Task<Book?> GetBook(int id)
        {
            return await _db.Books.FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<Book?> AddBook(CreateBookPayload payload)
        {
            var book = new Book() { Title = payload.Title, Author = payload.author };
            await _db.AddAsync(book);
            await _db.SaveChangesAsync();
            return book;
        }

        public async Task<Book?> UpdateBook(int id, UpdateBookPayload payload)
        {
            var book = await GetBook(id);
            if (book == null)
            {
                return null;
            }

            if (payload.Title != null)
            {
                book.Title = (string)payload.Title;
            }

            if (payload.Author != null)
            {
                book.Author = (Author)payload.Author;
            }

            await _db.SaveChangesAsync();
            return book;
        }

        public async Task<bool> DeleteBook(int id)
        {
            var book = await GetBook(id);
            if (book == null) return false;
            _db.Books.Remove(book);
            await _db.SaveChangesAsync();
            return true;
        }
    }
}
