using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class BookRepository: IRepository<Book, BookDTO>
    {
        DataContext _db;
        
        public BookRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Book>> GetAll()
        {
            return await _db.Books.Include(b => b.Author).ToListAsync();
        }

        public async Task<Book> Get(int id)
        {
            return await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<Book> Add(BookDTO entity)
        {
            Book book = new Book()
            {
                Title = entity.Title,
                AuthorId = entity.AuthorId
            };
            if (_db.Authors.Any(a => a.Id == entity.AuthorId))
            {
                await _db.Books.AddAsync(book);
                await _db.SaveChangesAsync();
                return await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == book.Id);
            }
            return null;
        }

        public async Task<Book> Update(int newAuthorId, BookDTO entity)
        {
            Book b = await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(i => i.Id == entity.Id);
            if(b == null)
            {
                return null;
            }
            b.AuthorId = newAuthorId;
            await _db.SaveChangesAsync();
            return await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(i => i.Id == b.Id);
        }

        public async Task<Book> Delete(int id)
        {
            Book b = await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(i => i.Id == id);
            if(b == null)
            {
                return null;
            }
            _db.Books.Remove(b);
            await _db.SaveChangesAsync();
            return b;
        }
    }
}
