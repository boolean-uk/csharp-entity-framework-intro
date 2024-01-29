using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly DataContext _db;

        public BookRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _db.Books.Include(b => b.Author).ToListAsync();
        }

        public async Task<Book> GetBookById(int id)
        {
            return await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == id);
        }
        public async Task<Author> GetAuthorById(int authorId)
        {
            return await _db.Authors.FindAsync(authorId);
        }

        public async Task SaveChanges()
        {
            await _db.SaveChangesAsync();
        }

        public async Task DeleteBook(Book book)
        {
            _db.Books.Remove(book);
            await SaveChanges();
        }

        public async Task AddBook(Book book)
        {
            _db.Books.Add(book);
            await SaveChanges();
        }
    }
}
