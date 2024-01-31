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

        public bool AuthorExists(int id)
        {
            var author = _db.Authors.FirstOrDefault(a => a.Id == id);
            if (author == null)
            {
               return false;
            }
            return true;
        }
        public async Task<Book> CreateBook(BookPost bookPost)
        {
            int id = _db.Books.Any() ? _db.Books.Max(b => b.Id) + 1 : 1;
            var author = _db.Authors.FirstOrDefault(a => a.Id == bookPost.AuthorId);
            Book book = new Book()
            {
                Id = id,
                Title = bookPost.Title,
                AuthorId = author.Id
            };
            _db.Books.Add(book);
            _db.SaveChanges();
            return await _db.Books.Include(b => b.Author).SingleOrDefaultAsync(b => b.Id == id);
        }

        public Task<bool> DeleteBookById(int id)
        {
            // Should it delete author?
            var book = _db.Books.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                _db.Books.Remove(book);
                _db.SaveChanges();
                return Task.FromResult(true);
            }
            return Task.FromResult(false);
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _db.Books.Include(b => b.Author).ToListAsync();
        }

        public async Task<Book> GetBookById(int id)
        {
            return await _db.Books.Include(b => b.Author).SingleOrDefaultAsync(b => b.Id == id); 
        }

        public async Task<Book> UpdateAuthorByBookId(int bookId, AuthorPut authorPut)
        {
            var book = _db.Books.Include(b => b.Author).FirstOrDefault(b => b.Id == bookId);
                    book.Author.FirstName = authorPut.FirstName;
                    book.Author.LastName = authorPut.LastName;
                    book.Author.Email = authorPut.Email;
            _db.SaveChanges();
            return await _db.Books.Include(b => b.Author).SingleOrDefaultAsync(b => b.Id == bookId);
        }
    }
}
