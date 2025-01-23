using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository;

public class BookRepository : IBookRepository
{
    DataContext _db;

    public BookRepository(DataContext db)
    {
        _db = db;
    }

    public async Task<Book?> CreateBook(Book book)
    {
        var result = _db.Books.Add(book);
        await _db.SaveChangesAsync();
        return await GetBook(result.Entity.Id);
    }

    public async Task<bool> DeleteBook(int id)
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

    public async Task<IEnumerable<Book>> GetAllBooks()
    {
        return await _db.Books.Include(b => b.Author).Include(b => b.Publisher).ToListAsync();
    }

    public async Task<Book?> GetBook(int id)
    {
        return await _db
            .Books.Include(b => b.Author)
            .Include(b => b.Publisher)
            .FirstOrDefaultAsync(b => b.Id == id);
    }

    public async Task<Book?> UpdateAuthor(int bookId, int authorId)
    {
        var author = await _db.Authors.FindAsync(authorId);
        if (author == null)
        {
            return null;
        }
        var entity = await _db.Books.FindAsync(bookId);
        if (entity == null)
        {
            return null;
        }
        entity.AuthorId = authorId;
        await _db.SaveChangesAsync();
        return entity;
    }
}
