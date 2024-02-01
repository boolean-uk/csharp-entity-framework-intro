using exercise.webapi.Data;
using exercise.webapi.Models;
using exercise.webapi.Models.DatabaseModels;
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

        public async Task<Book> GetABook(int id)
        {
            return await _db.Books.Include(b => b.Author).FirstAsync(b => b.Id == id);
        }

        public async Task<Book> UpdateBook(int id, BookDto input)
        {
            var updateBook = await _db.Books.Include(b => b.Author).FirstAsync(b => b.Id == id);
            if (updateBook == null)
            {
                return null;
            }
            updateBook.Title = input.Title;
            updateBook.AuthorId = input.AuthorId;
            updateBook.Author = await _db.Authors.FirstOrDefaultAsync(b => b.Id == updateBook.AuthorId);

            _db.SaveChangesAsync();
            return updateBook;
        }

        public async Task<Book> CreateBook(Book input)
        {
            if (_db.Books.Any(b => b.Title == input.Title))
            {
                return null;
            }
            Book newBook = new Book()
            {
                Title = input.Title,
                AuthorId = input.AuthorId,
                Id = (_db.Books.Count() == 0 ? 0 : _db.Books.Max(book => book.Id) + 1),
                Author = await _db.Authors.FirstOrDefaultAsync(a => a.Id == input.AuthorId)
            };
            _db.Books.Add(newBook);
            _db.SaveChangesAsync();
            return _db.Books.Last();
        }

        public async Task<Book> DeleteBook(int id)
        {
            var deletedBook = await _db.Books.Include(b => b.Author).FirstAsync(b => b.Id == id);
            _db.Books.Remove(deletedBook);
            _db.SaveChangesAsync();
            return deletedBook;
        }
    }
}
