using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;

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
            return await _db.Books
                .Include(b => b.Author)
                .Include(b => b.Publisher)
                .ToListAsync();
        }

        public async Task<Book?> GetBook(int id)
        {
            return await _db.Books
                .Include(b => b.Author)
                .Include(b => b.Publisher)
                .FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<Book?> UpdateBook(int bookId, int authorId)
        {
            Book? book = GetBook(bookId).Result;

            if (book == null)
                return null;

            book.AuthorId = authorId;
            await _db.SaveChangesAsync();

            // Reload the book to update the Author
            await _db.Entry(book).Reference(b => b.Author).LoadAsync();

            return book;
        }

        public async Task<Book?> DeleteBook(int id)
        {
            Book? book = GetBook(id).Result;

            if (book == null)
                return null;

            _db.Books.Remove(book);
            await _db.SaveChangesAsync();

            return book;
        }

        public async Task<Book?> CreateBook(Book book)
        {
            var authorExists = await _db.Authors.AnyAsync(a => a.Id == book.AuthorId);

            if (!authorExists)
                return null;

            _db.Books.Add(book);
            await _db.SaveChangesAsync();

            Book? createdBook = GetBook(book.Id).Result;

            return createdBook;
        }
    }
}
