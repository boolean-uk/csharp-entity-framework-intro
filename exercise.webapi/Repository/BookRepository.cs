using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.AspNetCore.Http.HttpResults;
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
            return await _db.Books.Include(b => b.Author).Include(b => b.Publisher).ToListAsync();

        }

        public async Task<Book> GetBook(int id)
        {
            return await _db.Books.Include(b => b.Author).Include(b => b.Publisher).FirstOrDefaultAsync(b => b.Id == id);

        }

        public async Task<Book> UpdateBook(int id, UpdateBookAuthorDTO updateDTO)
        {
            var book = await _db.Books.FindAsync(id);

            if (book == null)
                throw new Exception("Book not found");

            var authorExists = await _db.Authors.AnyAsync(a => a.Id == updateDTO.AuthorId);

            if (!authorExists)
                throw new Exception("Author not found");

            book.AuthorId = updateDTO.AuthorId;

            _db.Books.Update(book);
            await _db.SaveChangesAsync();

            return await _db.Books.Include(b => b.Author).Include(b => b.Publisher).FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<Book> DeleteBook(int id)
        {
            var book = await _db.Books
            .Include(b => b.Author)
            .Include(b => b.Publisher)
            .FirstOrDefaultAsync(b => b.Id == id);

            if (book == null)
                throw new Exception("Book not found");

            _db.Books.Remove(book);
            await _db.SaveChangesAsync();

            return book;
        }

        public async Task<Book> CreateBook(Book book)
        {
            var authorExists = await _db.Authors.AnyAsync(a => a.Id == book.AuthorId);

            if (!authorExists)
                throw new Exception("Author not found");

            _db.Books.Add(book);
            await _db.SaveChangesAsync();

            return await _db.Books
            .Include(b => b.Author)
            .Include(b => b.Publisher)
            .FirstOrDefaultAsync(b => b.Id == book.Id);
        }


    }
}
