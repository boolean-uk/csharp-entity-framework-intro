using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class Repository: IRepository
    {
        DataContext _db;
        
        public Repository(DataContext db)
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
            book.Author = await _db.Authors.FirstOrDefaultAsync(x => x.Id == book.AuthorId);

            _db.SaveChangesAsync();

            return await GetBookById(id);
        }
        public async Task<Book> DeleteBook(int id)
        {
            var book = await _db.Books.FirstOrDefaultAsync(x => x.Id == id);

            _db.Books.Remove(book);
            _db.SaveChangesAsync();

            return book;
        }
        public async Task<Book> CreateBook(InputBook newbook)
        {
            var author = await _db.Authors.FirstOrDefaultAsync(x => x.Id == newbook.AuthorId);
            if (author == null) { return null; }
            Book book = new Book();
            book.Id = _db.Books.Max(x => x.Id)+1;
            book.Title = newbook.Title;
            book.AuthorId=newbook.AuthorId;
            book.Author = author;
            _db.Books.Add(book);
            _db.SaveChangesAsync();

            return book;
        }
        public async Task<Author> GetAuthorById(int id)
        {
            return await _db.Authors.Include(a=>a.Books).FirstOrDefaultAsync(x => id == x.Id);
        }

        public async Task<IEnumerable<Author>> GetAllAuthors()
        {
            return await _db.Authors.Include(a => a.Books).ToListAsync();
        }
    }
}
