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
            return await _db.Books.Include(b => b.Author).Include(b => b.Publisher).ToListAsync();
        }

        public async Task<Book?> GetBookById(int id)
        {
            var book = await _db.Books.Include(b => b.Author).Include(b => b.Publisher).FirstOrDefaultAsync(x => x.Id == id);
            if (book == null)
                return null;

            return book;
        }

        public async Task<Book?> UpdateBook(int id, BookPost newBook)
        {
            var bookToUpdate = await _db.Books.Include(b => b.Author).Include(b => b.Publisher).FirstOrDefaultAsync(x => x.Id == id);
            if (bookToUpdate == null) return null;
            var author = await _db.Authors.FirstOrDefaultAsync(x => x.Id == newBook.AuthorId);
            if (author == null) return null;
            newBook.Title = !string.IsNullOrEmpty(newBook.Title) ? bookToUpdate.Title = newBook.Title : null!;
            bookToUpdate.Author = author;
            await _db.SaveChangesAsync();
            return bookToUpdate;
        }

        public async Task<Book?> DeleteBook(int id)
        {
            var bookToDelete = await _db.Books.Include(b => b.Author).Include(b => b.Publisher).FirstOrDefaultAsync(x => x.Id == id);
            if (bookToDelete == null) return null;
            _db.Books.Remove(bookToDelete);
            await _db.SaveChangesAsync();
            return bookToDelete;
        }

        public async Task<Book?> CreateBook(BookPost newBook)
        {
            var author = await _db.Authors.FirstOrDefaultAsync(x => x.Id == newBook.AuthorId);
            if (author == null) return null;
            Book book = new Book()
            {
                Title = newBook.Title,
                Author = author,
            };
            _db.Books.Add(book);
            await _db.SaveChangesAsync();
            return book;
        }

        public async Task<int> GetNewId()
        {
            return await _db.Books.MaxAsync(x => x.Id);
        }
    }
}
