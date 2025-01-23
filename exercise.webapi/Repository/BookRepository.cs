using exercise.webapi.Data;
using exercise.webapi.DTO;
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

        public async Task<Book> AddBook(Book Book)
        {
            if (_db.Authors.Find(Book.Author) == null)
            {
                return Book = null;
            }
            await _db.Books.AddAsync(Book);
            _db.Entry(Book).Reference(x => x.Author).Load();
            await _db.SaveChangesAsync();
            return Book;
        }

        public async Task<Book> AssignAuthor(int id, int authId)
        {
            var target = await _db.Books.FindAsync(id);
            target.AuthorId = authId;
            await _db.SaveChangesAsync();
            return target;
        }

        public async Task<bool> DeleteBook(int id)
        {
            var target = await _db.Books.FindAsync(id);
            _db.Books.Remove(target);
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _db.Books.Include(b => b.Author).ToListAsync();
        }

        public async Task<Book> GetBook(int id)
        {
            var target = await _db.Books.FindAsync(id);
            _db.Entry(target).Reference(x => x.Author).Load();
            return target;
        }

        public async Task<Book> RemoveAuthor(int id)
        {
            var target = await _db.Books.FindAsync(id);
            target.Author = null;
            target.AuthorId = 0;
            await _db.SaveChangesAsync();

            return target;
        }

        public async Task<Book> UpdateBook(Book Book)
        {
            var target = await _db.Books.FindAsync(Book.Id);
            _db.Books.Remove(target);
            await _db.SaveChangesAsync();

            await _db.Books.AddAsync(Book);
            await _db.SaveChangesAsync();
            _db.Entry(Book).Reference(x => x.Author).Load();
            return Book;
        }
    }
}
