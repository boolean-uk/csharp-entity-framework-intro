using exercise.webapi.Data;
using exercise.webapi.Endpoints;
using exercise.webapi.Models;
using exercise.webapi.Models.DatabaseModels;
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

        //Book Repository
        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _db.Books.Include(b => b.Author).Include(p => p.Publisher).ToListAsync();

        }

        public async Task<Book> GetBook(int id)
        {
            return await _db.Books.Include(b => b.Author).Include(p => p.Publisher).FirstAsync(b => b.Id == id);
        }

        public async Task<Book> UpdateBookAuthor (int id, Book book)
        {

            var result = _db.Books.Update(book);
            await _db.SaveChangesAsync();
            return await _db.Books.FirstAsync(b => b.Id == id);
            
        }
            
        public async Task<Book> DeleteBook (int id)
        {
            var book = await _db.Books.Include(b => b.Author).FirstAsync(b => b.Id == id);
            _db.Remove(book);
            await _db.SaveChangesAsync();
            return book;
        }

        public async Task<Book> CreateBook(Book book)
        {
            await _db.Books.AddAsync(book);
            await _db.SaveChangesAsync();
            return book;
        }

        //Author repository
        public async Task<IEnumerable<Author>> GetAllAuthors()
        {
            
            return await _db.Authors.Include(author => author.Books).Include(author => author.Publishers).ToListAsync();

            
        }

        public async Task<Author> GetAuthor(int id)
        {
            return await _db.Authors.Include(author => author.Books).Include(author => author.Publishers).FirstAsync(a => a.Id == id);
        }

        public async Task<IEnumerable<Publisher>> GetAllPublishers()
        {
            return await _db.Publishers.Include(p => p.Books).Include(p => p.Authors).ToListAsync();
        }

    }
}
