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

        public async Task<Book> GetBookById(int id)
        {
            return await _db.Books.Include(b => b.Author).FirstAsync(x=>x.Id==id);
        }

        public async Task<Book> UpdateBook(int id, int NewAuthorId)
        {
            var book = await _db.Books.FirstOrDefaultAsync(x => x.Id == id);

            book.AuthorId = NewAuthorId;
            book.Author = GetAuthorById(NewAuthorId).Result;

            _db.SaveChangesAsync();

            return await GetBookById(id);
        }
        public async Task<Author> GetAuthorById(int id)
        {
            return await _db.Authors.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Book> DeleteBook(int id)
        {
            var book = await _db.Books.FirstOrDefaultAsync(x => x.Id == id);

            _db.Books.Remove(book);
            _db.SaveChangesAsync();

            return book;
        }
        public async Task<Book> CreateBook(Book book)
        {
            var author = await _db.Authors.FirstOrDefaultAsync(x => x.Id == book.AuthorId);
            if (author == null) { return null; }

            book.Author = author;
            _db.Books.Add(book);
            _db.SaveChangesAsync();

            return book;
        }
    }
}
