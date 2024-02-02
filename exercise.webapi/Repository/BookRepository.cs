using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.AspNetCore.Mvc;
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

        public async Task<Book> GetBook(int id)
        {
            return await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<Book> DeleteBook(Book book)
        {
            if (!_db.Books.Contains(book)) return null;
            _db.Books.Remove(book);
            await _db.SaveChangesAsync();
            return book;
        }

        public async Task<Book> CreateBook(Book book)
        {
            _db.Books.Add(book);
            await _db.SaveChangesAsync();
            return book;
        }

        public async Task<Author> GetAuthor(int id)
        {
            return await _db.Authors.FirstOrDefaultAsync(a => a.Id == id);
        }
    }
}
