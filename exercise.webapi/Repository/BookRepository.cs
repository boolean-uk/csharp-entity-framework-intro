using exercise.webapi.Data;
using exercise.webapi.Models.InputTypes;
using exercise.webapi.Models.Types;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class BookRepository: IBookRepository
    {
        DatabaseContext _db;
        
        public BookRepository(DatabaseContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _db.Books.Include(b => b.AuthorBooks).ThenInclude(ab => ab.Author).Include(b => b.Publisher).ToListAsync();
        }

        public async Task<Book?> GetBookById(int id)
        {
            var book = await _db.Books.Include(b => b.AuthorBooks).ThenInclude(ab => ab.Author).Include(b => b.Publisher).FirstOrDefaultAsync(x => x.Id == id);
            if (book == null)
                return null;

            return book;
        }
        
        public async Task<Book?> UpdateBook(int id, BookPut newBook)
        {
            var bookToUpdate = await _db.Books.Include(b => b.AuthorBooks).ThenInclude(ab => ab.Author).Include(b => b.Publisher).FirstOrDefaultAsync(x => x.Id == id);
            if (bookToUpdate == null) return null;
            bookToUpdate.Title = newBook.Title;
            await _db.SaveChangesAsync();
            return bookToUpdate;
        }
        
        public async Task<Book?> DeleteBook(int id)
        {
            var bookToDelete = await _db.Books.Include(b => b.AuthorBooks).ThenInclude(ab => ab.Author).Include(b => b.Publisher).FirstOrDefaultAsync(x => x.Id == id);
            if (bookToDelete == null) return null;
            _db.Books.Remove(bookToDelete);
            await _db.SaveChangesAsync();
            return bookToDelete;
        }
        
        public async Task<Book?> CreateBook(BookPost newBook)
        {
            var publisher = await _db.Publishers.FirstOrDefaultAsync(p => p.Id == newBook.PublisherId);
            if (publisher == null) return null;
            Book book = new Book()
            {
                Title = newBook.Title,
                PublisherId = publisher.Id,
            };
            _db.Books.Add(book);
            await _db.SaveChangesAsync();
            return book;
        }
        
        public async Task<int> GetNewId()
        {
            return await _db.Books.MaxAsync(x => x.Id);
        }

        public async Task<Book?> AddAuthorToBook(Book book, int authorId)
        {
            var author = await _db.Authors.FirstOrDefaultAsync(a => a.Id == authorId);
            if (book == null || author == null) return null;
            var authorBook = book.AuthorBooks.FirstOrDefault(ab => ab.AuthorId == authorId);
            if (authorBook != null) return null;
            book.AuthorBooks.Add(new AuthorBook() { AuthorId = authorId, BookId = book.Id});
            await _db.SaveChangesAsync();
            return book;
        }

        public async Task<Book?> RemoveAuthorFromBook(Book book, int authorId)
        {
            var author = await _db.Authors.FirstOrDefaultAsync(a => a.Id == authorId);
            if (book == null || author == null) return null;
            var authorBook = book.AuthorBooks.FirstOrDefault(ab => ab.AuthorId == authorId);
            if (authorBook == null) return null;
            book.AuthorBooks.Remove(authorBook);
            await _db.SaveChangesAsync();
            return book;
        }
    }
}
